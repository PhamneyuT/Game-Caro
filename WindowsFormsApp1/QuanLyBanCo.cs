using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class QuanLyBanCo
    {
        #region Properties

        private Panel BanCo;
       
        #endregion

        #region Initialize

        public QuanLyBanCo(Panel BanCo)
        {
            this.BanCo = BanCo;
            
        }

        #endregion

        #region Methods

        public void VeBanCo()
        {
            //Button truoc cua moi button khi tao
            Button PreButton = new Button() { Width = 0, Location = new Point(0, 0) };
            

            //Vong lap de tao ban co
            for (int i = 0; i < Constant.ChieuCaoBanCo; i++)
            {
                for (int j = 0; j < Constant.ChieuRongBanCo; j++)
                {
                    Button btn = new Button();

                    btn.Width = Constant.ChieuCaoConCo;
                    btn.Height = Constant.ChieuCaoConCo;
                    btn.Location = new Point(PreButton.Location.X + PreButton.Width, PreButton.Location.Y);

                    //kich thuoc cua anh qua lon' nen phai chinh kich co cua anh cho vua` voi button
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    //Tao event khi nhan' vao button
                    btn.Click += Btn_Click;

                    BanCo.Controls.Add(btn);

                    //Gan button moi tao lam button truoc cua button chuan bi tao
                    PreButton = btn;
                }

                //Sau khi tao xong 1 hang trong ban co, thi set X cua pre button ve 0
                //Y cua prebutton duoc day xuong 1 doan = chieu rong cua 1 o
                PreButton.Location = new Point(0, PreButton.Location.Y + Constant.ChieuRongConCo);
                PreButton.Width = 0;
                PreButton.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X.png");
        }

        #endregion


    }
}
