using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyCLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();//Gọi class modify để thực hiện kết nối csdl và các câu lệnh sql
        QuanLyDoanhThu QLDT;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_CLB.DataSource = modify.DT("Select * from CLB");//Gọi hàm DT trong class modify và gắn string vào cho hàm
            }
            catch(SqlException ex)
            {
                DialogResult error = MessageBox.Show("Không lấy được dữ liệu", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while(error == DialogResult.Retry)
                {
                    dgv_CLB.DataSource = modify.DT("Select * from CLB");
                }
                if (error == DialogResult.Cancel)
                {

                }
            }
        }

        private void comboBox_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CLB.SelectedIndex >= 0)
            {
                this.dgv_CLB.Sort(this.dgv_CLB.Columns["CAU_LAC_BO"], ListSortDirection.Ascending);
                if (comboBox_CLB.SelectedIndex == 0)
                {
                    txt_GV.Text = "50";
                    txt_QG.Text = "Đức";
                    txt_SVD.Text = "Allianz Arena";
                    txt_SLV.Text = "75000";
                }
                if (comboBox_CLB.SelectedIndex == 1)
                {
                    txt_GV.Text = "60";
                    txt_QG.Text = "Anh";
                    txt_SVD.Text = "Old Trafford";
                    txt_SLV.Text = "74310";
                }
                if (comboBox_CLB.SelectedIndex == 2)
                {
                    txt_GV.Text = "45";
                    txt_QG.Text = "Anh";
                    txt_SVD.Text = "Emirates";
                    txt_SLV.Text = "59867";
                }
                if (comboBox_CLB.SelectedIndex == 3)
                {
                    txt_GV.Text = "85";
                    txt_QG.Text = "Tây Ban Nha";
                    txt_SVD.Text = "Santiago Bernabéu";
                    txt_SLV.Text = "81044";
                }
                if (comboBox_CLB.SelectedIndex == 4)
                {
                    txt_GV.Text = "40";
                    txt_QG.Text = "Italia";
                    txt_SVD.Text = "Giuseppe Meazza";
                    txt_SLV.Text = "75923";
                }
                if (comboBox_CLB.SelectedIndex == 5)
                {
                    txt_GV.Text = "62";
                    txt_QG.Text = "Tây Ban Nha";
                    txt_SVD.Text = "Cívitas Metropolitano";
                    txt_SLV.Text = "68456";
                }
                if (comboBox_CLB.SelectedIndex == 6)
                {
                    txt_GV.Text = "80";
                    txt_QG.Text = "Pháp";
                    txt_SVD.Text = "Parc des Princes";
                    txt_SLV.Text = "47930";
                }
                if (comboBox_CLB.SelectedIndex == 7)
                {
                    txt_GV.Text = "55";
                    txt_QG.Text = "Đức";
                    txt_SVD.Text = "Signal Iduna Park";
                    txt_SLV.Text = "81365";
                }
                if (comboBox_CLB.SelectedIndex == 8)
                {
                    txt_GV.Text = "44";
                    txt_QG.Text = "Anh";
                    txt_SVD.Text = "St James Park";
                    txt_SLV.Text = "52305";
                }
                if (comboBox_CLB.SelectedIndex == 9)
                {
                    txt_GV.Text = "58";
                    txt_QG.Text = "Ý";
                    txt_SVD.Text = "San Siro";
                    txt_SLV.Text = "75817";
                }
                if (comboBox_CLB.SelectedIndex == 10)
                {
                    txt_GV.Text = "55";
                    txt_QG.Text = "Anh";
                    txt_SVD.Text = "Etihad Stadium";
                    txt_SLV.Text = "53400";
                }
            }
            else
            {
                this.dgv_CLB.Sort(this.dgv_CLB.Columns["QUOC_GIA"], ListSortDirection.Ascending);
            }
        }

        private void txt_SLV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)) //Check nếu không phải số thì ko cho nhập
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }

        private void XoaTextBox()
        {
            comboBox_CLB.SelectedIndex = -1; 
            txt_GV.Text = "";
            txt_QG.Text = "";
            txt_SVD.Text = "";
            txt_SLV.Text = "";
            txt_Tong.Text = "";
        }
        private bool CheckTextBox() //Kiểm tra xem đã thỏa điều kiện chưa
        {
            if(comboBox_CLB.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn CLB","Thông Báo");
                return false;
            }
            if(txt_SLV.Text == "")
            {
                MessageBox.Show("Mời bạn nhập Số lượng vé", "Thông Báo");
                return false;
            }
            return true;
        }
        private void NhanGiaTriTxtBox()//Khởi tạo nhận Gía trị và tính tổng
        {
            string _CLB = comboBox_CLB.Text;
            string _QG = txt_QG.Text;
            double _GV = double.Parse(txt_GV.Text);
            string _SVD = txt_SVD.Text;
            int _SLV = int.Parse(txt_SLV.Text);
            QLDT = new QuanLyDoanhThu(_CLB, _QG, _GV, _SVD, _SLV);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(CheckTextBox()) 
            {
                NhanGiaTriTxtBox();
                string query = "Insert into CLB Values (N'" + QLDT.CLB + "',N'" + QLDT.QG + "',N'" + QLDT.SVD + "','" + QLDT.GV + "','" + QLDT.SLV + "','" + QLDT.Tong() + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        Form1_Load(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    DialogResult error = MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if(error != DialogResult.Cancel)
                    {
                        btn_Them_Click(sender,e);
                    }
                }
                XoaTextBox();
            }
        }

        private void dgv_CLB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_CLB.SelectedItem = dgv_CLB.CurrentRow.Cells[0].Value.ToString().Trim();
            txt_QG.Text = dgv_CLB.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_SVD.Text = dgv_CLB.CurrentRow.Cells[2].Value.ToString().Trim();
            txt_GV.Text = dgv_CLB.CurrentRow.Cells[3].Value.ToString().Trim();
            txt_SLV.Text = dgv_CLB.CurrentRow.Cells[4].Value.ToString().Trim();
            txt_Tong.Text = dgv_CLB.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                NhanGiaTriTxtBox();
                String query = "Update CLB Set [QUOC_GIA] = N'" + QLDT.QG + "',[SAN_VAN_DONG] = N'" + QLDT.SVD + "',[GIA_VE] = " + QLDT.GV + ",[SO_LUONG_VE] = '"
                    + QLDT.SLV + "',[TONG_TIEN]  = '" + QLDT.Tong() + "' Where [CAU_LAC_BO] = N'" + QLDT.CLB + "'";
                try
                {
                    if(MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thành công", "Thông Báo");
                        Form1_Load(sender, e);
                    }    
                }
                catch(Exception ex)
                {
                    DialogResult error = MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (error != DialogResult.Cancel)
                    {
                        btn_Them_Click(sender, e);
                    }
                }
                XoaTextBox();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                NhanGiaTriTxtBox();
                String query = "Delete From CLB where [CAU_LAC_BO] = N'" + QLDT.CLB + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    DialogResult error = MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (error != DialogResult.Cancel)
                    {
                        btn_Them_Click(sender, e);
                    }
                }
                XoaTextBox();
            }
        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_TenCLB_TextChanged(object sender, EventArgs e)
        {
            string TenCLB = txt_TenCLB.Text.Trim();
            if(TenCLB =="")
            {
                Form1_Load(sender, e);
            }    
            else
            {
                string query = "Select * from CLB where [CAU_LAC_BO] like N'%" + TenCLB + "%'";
                try
                {
                    dgv_CLB.DataSource = modify.DT(query);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không tìm thấy kết quả","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport rp = new FormReport();
            rp.ShowDialog();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lưu lại";
            saveFileDialog1.Filter = "Text file|*.txt |PDF file|*.pdf |All file|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog1.FileName);
                for(int i =0; i<dgv_CLB.Rows.Count-1; i++) 
                {
                    for(int j = 0; j < dgv_CLB.Columns.Count; j++)
                    {
                        writer.Write("\t" + dgv_CLB.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("===================================================================================================================");
                }
                writer.Close();
                MessageBox.Show("Xuất data thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu lại!");
            }
        }
    }
}
