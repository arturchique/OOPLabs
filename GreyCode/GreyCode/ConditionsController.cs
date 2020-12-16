using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreyCode
{
    class ConditionsController
    {
        public static void ConvertAndLoad(ConditionsModel model, int num, string sys_)
        {
            if (sys_ == "2")
            {
                model.sys_ = "2";
                model.num = BinToNum(num);
                model.bin = Convert.ToString(model.num, 2);
            }
            else if (sys_ == "10")
            {
                model.sys_ = "10";
                model.num = num;
                model.bin = Convert.ToString(model.num, 2);
            }
            model.numGrey = (model.num >> 1) ^ model.num;
            model.binGrey = Convert.ToString(model.numGrey, 2);
        }

        public static int BinToNum(int bin)
        {
            int res = 0;
            int power = 0;
            while (bin != 0)
            {
                res += bin % 10 * (int)Math.Pow(2, power);
                bin /= 10;
                power += 1;
            }
            return res;
        }

        public static bool IsNumValid(string num)
        {
            foreach (var ch in num)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsBinValid(string num)
        {
            foreach (var ch in num)
            {
                if ( (ch != '0') && (ch != '1') )
                {
                    return false;
                }
            }
            return true;
        }

        public static async void xorController(ConditionsModel model, Form1 form)
        {
            string shiftedBin = Convert.ToString(model.num >> 1, 2);
            if(shiftedBin.Length < model.bin.Length)
            {
                shiftedBin = shiftedBin.Insert(0, "0");
            }


            form.Controls.Add(new System.Windows.Forms.Label(){ Name = "binLabel", ForeColor = System.Drawing.Color.FromName("White"),
                                                                Location = new System.Drawing.Point(13, 13),
                                                                Size = new System.Drawing.Size(300, 15),
                                                                Text = "Бинарная запись числа: "});
            for (int i = 0; i < model.bin.Length; i++)
            {
                form.Controls.Add(new System.Windows.Forms.Label() { Name = "binLabel" + i.ToString(), ForeColor = System.Drawing.Color.FromName("White"),
                                                                     Location = new System.Drawing.Point(13 + 35 * i, 30),
                                                                     Size = new System.Drawing.Size(35, 35), 
                                                                     Text = model.bin[i].ToString(), 
                                                                     TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                                                                     BackColor = System.Drawing.Color.Transparent});
            }
            await Task.Delay(1000);


            form.Controls.Add(new System.Windows.Forms.Label(){ Name = "shiftedBinLabel", ForeColor = System.Drawing.Color.FromName("White"),
                                                                Location = new System.Drawing.Point(13, 70),
                                                                Size = new System.Drawing.Size(300, 15),
                                                                Text = "Выполняется бинарный сдвиг (>> 1): "});
            await Task.Delay(3000);
            for (int i = 0; i < model.bin.Length; i++)
            {
                form.Controls.Add(new System.Windows.Forms.Label() { Name = "shiftedBinLabel" + i.ToString(), 
                                                                     Location = new System.Drawing.Point(13 + 35 * i, 87),
                                                                     Size = new System.Drawing.Size(35, 35), 
                                                                     Text = shiftedBin[i].ToString(), ForeColor = System.Drawing.Color.FromName("White"),
                                                                     TextAlign = System.Drawing.ContentAlignment.MiddleCenter});
            }
            await Task.Delay(1000);



            form.Controls.Add(new System.Windows.Forms.Label(){ Name = "shiftedBinLabel", ForeColor = System.Drawing.Color.FromName("White"),
                                                                Location = new System.Drawing.Point(13, 123),
                                                                Size = new System.Drawing.Size(800, 15),
                                                                Text = "Выполняется исключающее или (n ^ m, где n -- бинарная запись числа, m = n >> 1): "});
            await Task.Delay(1000);
            for (int i = 0; i < model.bin.Length; i++)
            {
                (form.Controls["binLabel" + i.ToString()] as System.Windows.Forms.Label).BackColor = System.Drawing.Color.FromName("Green");
                (form.Controls["shiftedBinLabel" + i.ToString()] as System.Windows.Forms.Label).BackColor = System.Drawing.Color.FromName("Green");
                form.Controls.Add(new System.Windows.Forms.Label() { Name = "xorLabel" + i.ToString(), ForeColor = System.Drawing.Color.FromName("White"), 
                                                                     Location = new System.Drawing.Point(13 + 35 * i, 140),
                                                                     Size = new System.Drawing.Size(35, 35), 
                                                                     Text = ( Convert.ToInt32(shiftedBin[i]) ^ Convert.ToInt32(model.bin[i]) ).ToString(), 
                                                                     TextAlign = System.Drawing.ContentAlignment.MiddleCenter,});
                await Task.Delay(1000);
                (form.Controls["binLabel" + i.ToString()] as System.Windows.Forms.Label).BackColor = System.Drawing.Color.FromName("");
                (form.Controls["shiftedBinLabel" + i.ToString()] as System.Windows.Forms.Label).BackColor = System.Drawing.Color.FromName("");
            }

            System.Windows.Forms.Button button =  new System.Windows.Forms.Button();
            button.Text = "Показать результаты";
            button.Location = new System.Drawing.Point(13, 180);
            button.BackColor = System.Drawing.Color.FromArgb(5, 171, 94);
            button.Size = new System.Drawing.Size(279, 36);
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button.Click += (sender, e) => { form.Hide(); ConditionsView form1 = new ConditionsView(model); form1.Show(); };
            form.Controls.Add(button);
        }
    }
}
