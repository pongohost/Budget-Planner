using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Planner
{
    public partial class WorkDayTable : UserControl
    {
        public WorkDayTable()
        {
            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            this.dgv.Rows.Add("Jam Kerja", "","");
            this.dgv.Rows.Add("Hari Kerja Normal", "", "");
            this.dgv.Rows.Add("Hari Kerja Reguler", "", "");
            this.dgv.Rows.Add("Hari Jum'at(istirahat 2 jam)", "", "");
            this.dgv.Rows.Add("Libur Nasional (Beroperasi)", "", "");
            this.dgv.Rows.Add("Libur Nasional  (Tidak Beroperasi)", "", "");
            this.dgv.Rows.Add("Off", "", "");
            this.dgv.Rows.Add("Hari Pendek (Hari ke-6)", "", "");
            this.dgv.Rows.Add("Hari Spesial (Hari ke-7)", "", "");
            this.dgv.Rows.Add("Total Hari Kerja", "", "");
            this.dgv.Rows.Add("Total Hari Lembur", "", "");
            this.dgv.Rows[9].Cells[1].ReadOnly = true;
            this.dgv.Rows[10].Cells[1].ReadOnly = true;
            this.dgv.Rows[9].Cells[2].ReadOnly = true;
            this.dgv.Rows[10].Cells[2].ReadOnly = true;
        }

        private void Cell_edit(object sender, DataGridViewCellEventArgs e)
        {
            int kolom = dgv.CurrentCell.ColumnIndex;
            int baris = dgv.CurrentCell.RowIndex;
            int HKs1 = 0, HKs2 = 0, Lembur1 = 0, Lembur2 = 0;
            if (kolom == 1)
            {
                int nilai;
                if (int.TryParse(dgv.Rows[baris].Cells[2].Value.ToString(),out nilai))
                {
                    //MessageBox.Show(nilai.ToString());
                }
                else
                {                    
                    dgv.Rows[baris].Cells[2].Value = dgv.SelectedCells[0].Value.ToString();
                }
            }
            for(int i = 1; i < 9; i++)
            {
                int tempInt1,tempInt2;
                int.TryParse(this.dgv.Rows[i].Cells[1].Value.ToString(), out tempInt1);
                int.TryParse(this.dgv.Rows[i].Cells[2].Value.ToString(), out tempInt2);
                HKs1 = HKs1 + tempInt1;
                HKs2 = HKs2 + tempInt2;
            }
            this.dgv.Rows[9].Cells[1].Value = HKs1;
            this.dgv.Rows[9].Cells[2].Value = HKs2;
            this.dgv.Rows[10].Cells[1].Value = HitungLembur(1);
            this.dgv.Rows[10].Cells[2].Value = HitungLembur(2);

        }

        private Double HitungLembur(int kolom)
        {
            Double lembur = 0;
            Double jamKerja, Hari;
            Double.TryParse(this.dgv.Rows[0].Cells[kolom].Value.ToString(), out jamKerja);
            Double.TryParse(this.dgv.Rows[1].Cells[kolom].Value.ToString(), out Hari);
            lembur = Math.Max((((jamKerja - 8)*2)+1.5)*Hari,0);
            Double.TryParse(this.dgv.Rows[3].Cells[kolom].Value.ToString(), out Hari);
            lembur = lembur + Math.Max((((jamKerja - 9) * 2) + 1.5) * Hari, 0);
            Double.TryParse(this.dgv.Rows[4].Cells[kolom].Value.ToString(), out Hari);
            lembur = lembur + Math.Max((((jamKerja - 8) * 4) + 3+(7*2)) * Hari, 0);
            Double.TryParse(this.dgv.Rows[7].Cells[kolom].Value.ToString(), out Hari);
            lembur = lembur + Math.Max((((jamKerja - 6) * 2) + 1.5) * Hari, 0);
            Double.TryParse(this.dgv.Rows[8].Cells[kolom].Value.ToString(), out Hari);
            lembur = lembur + Math.Max((((jamKerja - 8) * 4) + 3 + (7 * 2)) * Hari, 0);
            return lembur;
        }

        private void Cell_NumberOnly(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Key_NumberOnly);
            }
        }

        private void Key_NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clr_s1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i++)
            {
                dgv.Rows[i].Cells[1].Value = "";
            }
        }

        private void clr_s2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                dgv.Rows[i].Cells[2].Value = "";
            }
        }

        public String TitleText
        {
            get { return this.titel_txt.Text; }
            set { this.titel_txt.Text = value; }
        }

        public DataGridView DgValue
        {
            get { return this.dgv; }
            set { this.dgv = value; }
        }
    }
}
