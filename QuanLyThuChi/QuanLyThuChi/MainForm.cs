using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
namespace QuanLyThuChi
{

    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        public MainForm()
        {
            InitializeComponent();
           
            BindingList<Customer> dataSource = GetDataSource();
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;

        }
   
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            KT();
        }

        private void btnphieuthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhieuThu f = new frm_PhieuThu();
            f.MdiParent = this;
            f.Show();
        }

        private void btndkhangmucchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DangKyHangMucThu pg = new frm_DangKyHangMucThu();
            if (ExistForm(pg))
                return;
            pg.MdiParent = this;
            pg.Show();
        }

        private void btndkhangmucthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DangKyKhoanChi pg = new frm_DangKyKhoanChi();
            if (ExistForm(pg))
                return;
            pg.MdiParent = this;
            pg.Show();
        }

        private void btnPhieuChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_LapPhieuChi frm = new frm_LapPhieuChi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK frmdoimk = new frmDoiMK();
            frmdoimk.ShowDialog();
            //frmdoimk.MdiParent = this;
            //frmdoimk.Show();
        }

       

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QL_NguoiDung frm = new frm_QL_NguoiDung();

            frm.MdiParent = this;
            frm.Show();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public void KT()
        {
            foreach (RibbonPage group in ribbonControl.Pages)
            {
                MessageBox.Show(group.Text);
            }

        }



        private bool ExistForm(Form a)
        {
            foreach (Form child in MdiChildren)
            {
                if (child.Name == a.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btn_dktiente_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DangKyTienTe pg = new frm_DangKyTienTe();
            if (ExistForm(pg))
                return;
            pg.MdiParent = this;
            pg.Show();
        }


    }
}