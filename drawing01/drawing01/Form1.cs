using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();


            Pen myPen1 = new Pen(System.Drawing.Color.Green, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Yellow, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.CadetBlue, 5);

            //h
            myGraphic.DrawLine(myPen1,85,37,85,90);
            myGraphic.DrawLine(myPen1, 85, 65, 109, 65);//-
            myGraphic.DrawLine(myPen1, 109, 37, 109, 90);
            //A
            myGraphic.DrawLine(myPen1, 150, 37, 125, 90);
            myGraphic.DrawLine(myPen1, 150, 37, 171, 90);
            myGraphic.DrawLine(myPen1, 137, 65, 161, 65);
            //P
            myGraphic.DrawLine(myPen1, 185, 37, 185, 90);
            myGraphic.DrawLine(myPen1, 185, 37, 210, 37);//-บน
            myGraphic.DrawLine(myPen1, 210, 37, 210, 60);
            myGraphic.DrawLine(myPen1, 185, 60, 210, 60);//-ล่าง
            //P
            myGraphic.DrawLine(myPen1, 234, 37, 234, 90);
            myGraphic.DrawLine(myPen1, 234, 37, 268, 37);//-บน
            myGraphic.DrawLine(myPen1, 268, 37, 268, 60);
            myGraphic.DrawLine(myPen1, 234, 60, 268, 60);//ล่าง
            //Y
            myGraphic.DrawLine(myPen1, 280, 33, 292, 60);
            myGraphic.DrawLine(myPen1, 304, 33, 292, 60);
            myGraphic.DrawLine(myPen1, 292, 60, 292, 90);
            //N
            myGraphic.DrawLine(myPen1, 322, 37, 322, 90);
            myGraphic.DrawLine(myPen1, 322, 37, 348, 90);
            myGraphic.DrawLine(myPen1, 348, 37, 348, 90);
            //E
            myGraphic.DrawLine(myPen1, 370, 37, 370, 90);
            myGraphic.DrawLine(myPen1, 370, 37, 400, 37);
            myGraphic.DrawLine(myPen1, 370, 60, 400, 60);
            myGraphic.DrawLine(myPen1, 370, 90, 400, 90);
            //W
            myGraphic.DrawLine(myPen1, 420, 37, 420, 90);
            myGraphic.DrawLine(myPen1, 420, 90, 440, 60);
            myGraphic.DrawLine(myPen1, 440, 60, 460, 90);
            myGraphic.DrawLine(myPen1, 460, 37, 460, 90);
            //Y
            myGraphic.DrawLine(myPen1, 156, 127, 170, 160);
            myGraphic.DrawLine(myPen1, 190, 127, 170, 160);
            myGraphic.DrawLine(myPen1, 170, 160, 170, 190);
            //E
            myGraphic.DrawLine(myPen1, 210, 127, 210, 190);
            myGraphic.DrawLine(myPen1, 210, 127, 250, 127);
            myGraphic.DrawLine(myPen1, 210, 160, 250, 160);
            myGraphic.DrawLine(myPen1, 210, 190, 250, 190);
            //A
            myGraphic.DrawLine(myPen1, 290, 127, 260, 190);
            myGraphic.DrawLine(myPen1, 290, 127,330 , 190);
            myGraphic.DrawLine(myPen1, 275, 160, 310, 160);
            //R
            myGraphic.DrawLine(myPen1, 350, 127, 350, 190);
            myGraphic.DrawLine(myPen1, 350, 127, 390, 127);
            myGraphic.DrawLine(myPen1, 390, 127, 390, 160);
            myGraphic.DrawLine(myPen1, 350, 160, 390, 160);
            myGraphic.DrawLine(myPen1, 350, 160, 390, 190);
            //ต้นคริสมาส
            myGraphic.DrawLine(myPen1, 98, 225, 48, 262);
            myGraphic.DrawLine(myPen1, 48, 262, 72, 262);
            myGraphic.DrawLine(myPen1, 98, 225, 148, 262);
            myGraphic.DrawLine(myPen1, 117,262, 148, 262);
            myGraphic.DrawLine(myPen1, 72, 262, 28, 300);
            myGraphic.DrawLine(myPen1, 28, 300, 74, 300);
            myGraphic.DrawLine(myPen1, 98, 225, 148, 262);
            myGraphic.DrawLine(myPen1, 117, 262, 166, 300);
            myGraphic.DrawLine(myPen1 ,117 , 300, 166, 300);
            myGraphic.DrawLine(myPen1, 12, 340, 72, 300);
            myGraphic.DrawLine(myPen1, 12, 340, 72, 340);
            myGraphic.DrawLine(myPen1, 117, 300, 177, 340);
            myGraphic.DrawLine(myPen1, 117, 340, 177, 340);
            myGraphic.DrawLine(myPen1, 1, 380, 72, 340);
            myGraphic.DrawLine(myPen1, 117, 340, 184, 380);
            myGraphic.DrawLine(myPen1, 1, 380, 184, 380);
            myGraphic.DrawLine(myPen1, 80, 380, 80, 500);
            myGraphic.DrawLine(myPen1, 120, 380, 120, 500);
            //กล่องของขวัญ
            myGraphic.DrawLine(myPen1, 423, 250, 423, 350);
            myGraphic.DrawLine(myPen1, 423, 250, 550, 250);
            myGraphic.DrawLine(myPen1, 550, 350, 550, 350);
            myGraphic.DrawLine(myPen1, 550, 250, 550, 350);
            myGraphic.DrawLine(myPen1, 423, 350, 550, 350);
            myGraphic.DrawLine(myPen1, 485, 250, 485, 350);
            myGraphic.DrawLine(myPen1, 423, 300, 550, 300);
            //โบว์กล่อง
            myGraphic.DrawLine(myPen1, 440, 239, 485, 250);
            myGraphic.DrawLine(myPen1, 440, 227, 440, 240);
            myGraphic.DrawLine(myPen1, 440, 227, 485, 250);
            myGraphic.DrawLine(myPen1, 530, 227, 530, 240);
            myGraphic.DrawLine(myPen1, 485, 250, 530, 239);
            myGraphic.DrawLine(myPen1, 530, 227, 485, 250);
            //ลูกโป่ง
            myGraphic.DrawEllipse(myPen2, 500, 60, 60, 60); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            myGraphic.DrawEllipse(myPen2, 480, 90, 90, 90);
          











        }
    }
}
