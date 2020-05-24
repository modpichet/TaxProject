using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI;

namespace Tax_Project
{
    public partial class Form1 : Form

    {
        int marry = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }

        private void reduce_Click(object sender, EventArgs e)
        {
            group1.BringToFront();
        }

        private void nexttogroup2_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void backhome_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }

        private void togroup3_Click(object sender, EventArgs e)
        {
            group3.BringToFront();
        }

        private void backtogroup1_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

   
        private void backbt_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void nexttogroup4_Click(object sender, EventArgs e)
        {
            group4.BringToFront();
        }

        private void backtogroup3_Click(object sender, EventArgs e)
        {
            group3.BringToFront();
        }

        private void group4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nexttogroup5_Click(object sender, EventArgs e)
        {
            group5.BringToFront();
        }

        //ปุ่มไปหน้าแต่ละหน้า ในgroup1
        private void gunaCircleButton16_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

        //ปุ่มไปหน้าแต่ละหน้า ในgroup2
        private void CircleButton2_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void CircleButton1_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

        //ปุ่มไปหน้าแต่ละหน้า ในgroup3
        private void backtogroup4_Click(object sender, EventArgs e)
        {
            group4.BringToFront();
        }
        private void gunaCircleButton11_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

        private void gunaCircleButton8_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void gunaCircleButton7_Click(object sender, EventArgs e)
        {
            group3.BringToFront();
        }

        //ปุ่มไปหน้าแต่ละหน้า ในgroup4
        private void nexttogroup1_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }
        private void gunaCircleButton21_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

        private void gunaCircleButton20_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void gunaCircleButton19_Click(object sender, EventArgs e)
        {
            group3.BringToFront();
        }

        private void gunaCircleButton22_Click(object sender, EventArgs e)
        {
            group4.BringToFront();
        }

        //ปุ่มไปหน้าแต่ละหน้า ในgroup5
        private void gunaCircleButton26_Click(object sender, EventArgs e)
        {
            group11.BringToFront();
        }

        private void gunaCircleButton25_Click(object sender, EventArgs e)
        {
            group2.BringToFront();
        }

        private void gunaCircleButton24_Click(object sender, EventArgs e)
        {
            group3.BringToFront();
        }

        private void gunaCircleButton27_Click(object sender, EventArgs e)
        {
            group4.BringToFront();
        }

        private void gunaCircleButton28_Click(object sender, EventArgs e)
        {
            group5.SuspendLayout();
        }


        private void gotoreport_Click(object sender, EventArgs e)
        {
            report.BringToFront();

            try
            {

            //คำนวณรายได้ทั้งหมด
            int salary = int.Parse(salarytb.Text);
            int bonus = int.Parse(bonustb.Text);
            int other = int.Parse(othertb.Text);
            int income = (salary * 12) + other + bonus; //netmoney คือ รายได้ทั้งหมด;

            //คำนวณรายจ่าย
            //คิดจาก 50 % ของรายได้ทั้งหมด แต่จะได้ไม่เกิน 100,000 บาท
            int expenses_50 = (income *50)/100;
                if(expenses_50 > 100000)
                {
                    expenses_50 = 100000;
                }
                else if(expenses_50 < 100000)
                {
                    expenses_50 = (income * 50) / 100;
                }


            //ค่าลดหย่อนกลุ่ม ตัวเองและครอบครัว
                int self = 60000;
            int childbefore61 = int.Parse(childbefore61Tb.Text);
            int childafter61 = int.Parse(childafter61Tb.Text);
            int calve = int.Parse(calveTextBox.Value.ToString());
            int disable = int.Parse(disableTextBox.Text);
            int self_parent = int.Parse(self_parentTb.Value.ToString());
            int spouse_parent = int.Parse(self_parentTb.Value.ToString());
            int childbefore61_2 = 0;//
            if (childbefore61 > 2)
            {
                childbefore61_2 = (childbefore61 - 2) * 60000;
            }
       


            int taxgroup1 = self + marry + (childbefore61 * 30000) + (childafter61 * 60000) + childbefore61_2+ (self_parent * 30000) + (spouse_parent * 30000) + calve + disable;

            //ค่าลดหย่อนกลุ่ม ประกันเงินออมและการลงทุน
            int social = int.Parse(socialtb.Text);//ประกันสังคม
            int life = int.Parse(lifetb.Text);//ประกันชีวิต
            int health = 0;//ประกันสุขภาพ
            int health_parent = int.Parse(health_parenttb.Text);//ประกันสุขภาพบิดา-มารดา
            int spouse_life = int.Parse(spousetb.Text);//ประกันชีวิตคู่สมรส 
            int reserve_money = int.Parse(reserv_lifetb.Text);//เงินกองทุนสำรองเลี้ยงชีพ 
            int KBK = int.Parse(KBKtb.Text);//กบข

            if ((life + health) >= 100000)//ประกันชีวิต + ประกันสุขภาพ >= 100,000
            {
                health = 15000;
            }
            else if (health >= 15000)
            {
                health = 15000;
            }
            else if (health < 15000)
            {
                health = int.Parse(healthtb.Text);
            }

            int taxgroup2 = social + life + health + health_parent + spouse_life + reserve_money + KBK;

            //ค่าลดหย่อนกลุ่มอสังหาริมทรัพย์ 
            int house_interest = int.Parse(housetb.Text);
            int price58 = int.Parse(price58textbox.Text);
            int allpreduce = 0;
            int preduce4 = 0;
            int price62 = int.Parse(price62textbox.Text);
            int preduce62 = 0;
            //int preduce4_1 = int.Parse(preduce4tb.Text);
            //int preduce_1 = int.Parse(preducetb.Text);
            if(house58CheckBox.Checked == true)
            {
                if (price58 < 3000000)
                {
                    allpreduce = ((price58 * 20) / 100);
                    allpreducetb.Text = allpreduce.ToString();
                    preduce4 = ((price58 * 4) / 100);
                    preduce4tb.Text = preduce4.ToString();
                }
                else if(price58 > 3000000)
                {
                    MessageBox.Show("ไม่สามารถลดหย่อนได้");
                    preduce4tb.Enabled = false;
                    allpreducetb.Enabled = false;
                }
            }

            if(house62CheckBox.Checked == true)
            {
                if (price62 < 5000000)
                {
                    preduce62 = 200000;
                    preducetb.Text = preduce62.ToString();
                }
                else if (price62 < 200000)
                {
                    preducetb.Text = preduce62.ToString();
                }
                else if (price58 > 5000000)
                {
                    MessageBox.Show("ไม่สามารถลดหย่อนได้");
                    allpreducetb.Enabled = false;
                }
            }
         

            int taxgroup3 = house_interest + preduce4 + preduce62;


            //ค่าลดหย่อนกลุ่มเงินบริจาค 
            int ED = int.Parse(EDTb.Text);
            int hospital = int.Parse(hospitalTb.Text);
            int sport = int.Parse(sportTB.Text);
            int benefit = int.Parse(benefitTb.Text);
            int flood = int.Parse(floodTb.Text);
            int general = int.Parse(generalTb.Text);
            int politics = int.Parse(politicsTb.Text);

            int taxgroup4 = (ED * 2) + (hospital * 2) + (sport * 2) + (benefit * 2) + (flood * 2) + (flood * 2) + politics;

            //ค่าลดหย่อนกลุ่มมาตรการกระตุ้นเศรษฐกิจของรัฐ 
            int Shop = int.Parse(shopTb.Text);
            int Buy_ED_Sport = int.Parse(Buy_ED_SportTb.Text);
            int Buy_Book = int.Parse(Buy_BookTb.Text);
            int Buy_Otop = int.Parse(Buy_OtopTb.Text);
            int Travel_1 = int.Parse(Travel_1Tb.Text);
            int Travel_2 = int.Parse(Travel_2Tb.Text);
            int Home_repair = int.Parse(Home_RepairTb.Text);
            int Car_repair = int.Parse(Car_Repair.Text);
            int Travel1_2 = 0;
            if ((Travel_1 + Travel_2) > 20000)
            {
                Travel1_2 = 20000;
            }
            else if ((Travel_1 + Travel_2) < 20000)
            {
                Travel1_2 = Travel_1 + Travel_2;
            }

            int taxgroup5 = Shop + Buy_ED_Sport + Buy_Book + Buy_Otop + Travel1_2 + Home_repair + Car_repair;

            //รวมค่าลดหย่อนทั้งหมด
            int deduction = taxgroup1 + taxgroup2 + taxgroup3 + taxgroup4 + taxgroup5;
            deductiontextBox.Text = deduction.ToString();

            //รายได้สุทธิ
            int netmoney = income - expenses_50 - deduction;//รายได้สุทธิ = รายได้ทั้งหมด - รายจ่าย 50% - ค่าลดหย่อน
            netmoneytextBox.Text = netmoney.ToString();//เขียนค่า รายได้สุทธิ ลงใน  netmoneytextBox 
                int pay;
            if (netmoney > 5000001) //ถ้ารายได้สุทธิมากกว่า 5000001 
            {
                pay = (netmoney * 35) / 100; //ภาษาที่ต้องจ่ายคือ 35% ของรายได้สุทธิ
                Pay_TaxTextBox.Text = pay.ToString();//เขียนค่า ภาษีที่ต้องจ่าย ลงใน    Pay_TaxTextBox
                }
            else if (netmoney >= 2000001)
            {
                pay = (netmoney * 30) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney >= 1000001)
            {
                pay = (netmoney * 25) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney >= 750001)
            {
                pay = (netmoney * 20) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney >= 500001)
            {
                pay = (netmoney * 15) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney >= 300001)
            {
                pay = (netmoney * 10) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney >= 150001)
            {
                pay = (netmoney * 5) / 100;
                Pay_TaxTextBox.Text = pay.ToString();
            }
            else if (netmoney <= 150000)
            {

                Pay_TaxTextBox.Text = ("ไม่ต้องจ่ายภาษี").ToString();
            }


            //หน้าสรุปผล
            deductiontextBox.Text = deduction.ToString();
            netmoneytextBox.Text = netmoney.ToString();


            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message, "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void reportbt_Click(object sender, EventArgs e)
        {
            report.BringToFront();
        }



        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gunaComboBox2.Text == "โสด" )
            {
                spouse_parentTb.Enabled = false;

            }
            else
            {
                spouse_parentTb.Enabled = true;
            }

            if (gunaComboBox2.Text == "คู่สมรสไม่มีเงินได้")
            {
                marry = 60000;
                spousetb.Enabled = true;
            }
            else
            {
                marry = 0;
                spousetb.Enabled = true;
            }
        }

        private void price58textbox_TextChanged(object sender, EventArgs e)
        {
            int price58 = int.Parse(price58textbox.Text);
            if (price58 > 3000000)
            {
                MessageBox.Show("ราคาบ้านเกิน 3,000,000 บาท ไม่สามารถลดหย่อนได้");
                preduce4tb.Enabled = false;
                preducetb.Enabled = false;
            }
            else if (price58 < 3000000)
            {
                preduce4tb.Enabled = true;
                preducetb.Enabled = true;
            }
        }

        private void house58CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (house58CheckBox.Checked == true)
            {
                house58groupBox.Enabled = true;
            }
            else if (house58CheckBox.Checked == false)
            {
                house58groupBox.Enabled = false;
            }
        }

        private void house62CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (house62CheckBox.Checked == true)
            {
                house62groupBox.Enabled = true;
            }
            else if (house62CheckBox.Checked == false)
            {
                house62groupBox.Enabled = false;
            }
        }

        private void price62textbox_TextChanged(object sender, EventArgs e)
        {
            int price62 = int.Parse(price62textbox.Text);
            if (price62 > 5000000)
            {
                MessageBox.Show("ราคาบ้านเกิน 5,000,000 บาท ไม่สามารถลดหย่อนได้");
                preducetb.Enabled = false;
            }
            else if (price62 < 5000000)
            {
                preducetb.Enabled = true;
            }
        }
    }
}
