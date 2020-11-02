using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicket
{
    public partial class FormSellsTicket : Form
    {
        public int FTripID { get; set; }
        public string fstarttime { get; set; }
        public decimal PerSeatPrice { get; set; }
        public int FFromCounter { get; set; }
        public int FToCounter { get; set; }
        public DateTime FSearchDate { get; set; }
        public FormSellsTicket(int TripID, int FromCounter, int ToCounter,DateTime SearchDate,string starttime)
        {
            InitializeComponent();
            FTripID = TripID;
            FFromCounter = FromCounter;
            FToCounter = ToCounter;
            FSearchDate = SearchDate;
            fstarttime = starttime;
        }


        public string CallerForm
        {
            get;
            set;
        }

        private void FormSellsTicket_Load(object sender, EventArgs e)
        {
            cmbBoxload();
        }
        void SelectColor(Color a,string seat, Boolean ena)
        {
            switch (seat)
            {
                case "A1":
                    {
                        btnA1.Enabled = ena;
                        btnA1.BackColor = a;
                        break;
                    }

                case "A2":
                    {
                        btnA2.Enabled = ena;
                        btnA2.BackColor = Color.Red;
                        break;
                    }
                case "A3":
                    {
                        btnA3.Enabled = ena;
                        btnA3.BackColor = a;
                        break;
                    }
                case "A4":
                    {
                        btnA4.Enabled = ena;
                        btnA4.BackColor = a;
                        break;
                    }
                case "B1":
                    {
                        btnB1.Enabled = ena;
                        btnB1.BackColor = a;
                        break;
                    }
                case "B2":
                    {
                        btnB2.Enabled = ena;
                        btnB2.BackColor = a;
                        break;
                    }
                case "B3":
                    {
                        btnB3.Enabled = ena;
                        btnB3.BackColor =a;
                        break;
                    }
                case "B4":
                    {
                        btnB4.Enabled = ena;
                        btnB4.BackColor =a;
                        break;
                    }
                case "C1":
                    {
                        btnC1.Enabled = ena;
                        btnC1.BackColor = a;
                        break;
                    }
                case "C2":
                    {
                        btnC2.Enabled = ena;
                        btnC2.BackColor = a;
                        break;
                    }
                case "C3":
                    {
                        btnC3.Enabled = ena;
                        btnC3.BackColor =a;
                        break;
                    }
                case "C4":
                    {
                        btnC4.Enabled = ena;
                        btnC4.BackColor =a;
                        break;
                    }
                case "D1":
                    {
                        btnD1.Enabled = ena;
                        btnD1.BackColor = a;
                        break;
                    }
                case "D2":
                    {
                        btnD2.Enabled = ena;
                        btnD2.BackColor = a;
                        break;
                    }
                case "D3":
                    {
                        btnD3.Enabled = ena;
                        btnD3.BackColor = a;
                        break;
                    }
                case "D4":
                    {
                        btnD4.Enabled = ena;
                        btnD4.BackColor = a;
                        break;
                    }
                case "E1":
                    {
                        btnE1.Enabled = ena;
                        btnE1.BackColor = a;
                        break;
                    }
                case "E2":
                    {
                        btnE2.Enabled = ena;
                        btnE2.BackColor = a;
                        break;
                    }
                case "E3":
                    {
                        btnE3.Enabled = ena;
                        btnE3.BackColor = a;
                        break;
                    }
                case "E4":
                    {
                        btnE4.Enabled = ena;
                        btnE4.BackColor = a;
                        break;
                    }
                case "F1":
                    {
                        btnF1.Enabled = ena;
                        btnF1.BackColor = a;
                        break;
                    }
                case "F2":
                    {
                        btnF2.Enabled = ena;
                        btnF2.BackColor = a;
                        break;
                    }
                case "F3":
                    {
                        btnF3.Enabled = ena;
                        btnF3.BackColor = a;
                        break;
                    }
                case "F4":
                    {
                        btnF4.Enabled = ena;
                        btnF4.BackColor = a;
                        break;
                    }
                case "G1":
                    {
                        btnG1.Enabled = ena;
                        btnG1.BackColor = a;
                        break;
                    }
                case "G2":
                    {
                        btnG2.Enabled = ena;
                        btnG2.BackColor = a;
                        break;
                    }
                case "G3":
                    {
                        btnG3.Enabled = ena;
                        btnG3.BackColor = a;
                        break;
                    }
                case "G4":
                    {
                        btnG4.Enabled = ena;
                        btnG4.BackColor = a;
                        break;
                    }
                case "H1":
                    {
                        btnH1.Enabled = ena;
                        btnH1.BackColor = a;
                        break;
                    }
                case "H2":
                    {
                        btnH2.Enabled = ena;
                        btnH2.BackColor = a;
                        break;
                    }
                case "H3":
                    {
                        btnH3.Enabled = ena;
                        btnH3.BackColor = a;
                        break;
                    }
                case "H4":
                    {
                        btnH4.Enabled = ena;
                        btnH4.BackColor = a;
                        break;
                    }
                case "I1":
                    {
                        btnI1.Enabled = ena;
                        btnI1.BackColor = a;
                        break;
                    }
                case "I2":
                    {
                        btnI2.Enabled = ena;
                        btnI2.BackColor = a;
                        break;
                    }
                case "I3":
                    {
                        btnI3.Enabled = ena;
                        btnI3.BackColor = a;
                        break;
                    }
                case "I4":
                    {
                        btnI4.Enabled = ena;
                        btnI4.BackColor = a;
                        break;
                    }
                case "J1":
                    {
                        btnJ1.Enabled = ena;
                        btnJ1.BackColor = a;
                        break;
                    }
                case "J2":
                    {
                        btnJ2.Enabled = ena;
                        btnJ2.BackColor = a;
                        break;
                    }
                case "J3":
                    {
                        btnJ3.Enabled = ena;
                        btnJ3.BackColor = a;
                        break;
                    }
                case "J4":
                    {
                        btnJ4.Enabled = ena;
                        btnJ4.BackColor = a;
                        break;
                    }
            }
        }

       void cmbBoxload()
        {
            btnUnBook.Enabled = false;
            using (BusDBEntities db = new BusDBEntities())
            {
                
                cmbBoarding.DataSource = db.CounterInfoTBs.Where(a => a.ID == FFromCounter).ToList();
                cmbBoarding.ValueMember = "ID";
                cmbBoarding.DisplayMember = "Name";

                cmbDroping.DataSource = db.CounterInfoTBs.Where(a => a.ID == FToCounter).ToList();
                cmbDroping.ValueMember = "ID";
                cmbDroping.DisplayMember = "Name";
                  txtBoardingTime.Text = FSearchDate.Date.ToString("dd/MM/yyyy")+" "+fstarttime;
                
                TripInfoTB atrip;
                atrip = db.TripInfoTBs.SingleOrDefault(a=>a.ID==FTripID);
                if(atrip!=null)
                {
                    if (atrip.BusInfoTB.TotalSits < 40)
                    {
                        if (atrip.BusInfoTB.TotalSits == 36 )
                        {
                            btnJ1.Visible = btnJ2.Visible = btnJ3.Visible = btnJ4.Visible = false;
                        }

                        else if (atrip.BusInfoTB.TotalSits == 31 )
                        {
                            btnA2.Visible = btnB2.Visible = btnC2.Visible = btnD2.Visible = btnE2.Visible = btnF2.Visible = btnG2.Visible 
                                = btnH2.Visible = btnI2.Visible = false;
                        }

                       else  if (atrip.BusInfoTB.TotalSits == 28)
                        {
                            btnA2.Visible = btnB2.Visible = btnC2.Visible = btnD2.Visible = btnE2.Visible = btnF2.Visible = btnG2.Visible = btnH2.Visible = false;
                            btnJ1.Visible = btnJ2.Visible = btnJ3.Visible = btnJ4.Visible = false;
                        }
                    }
                    PerSeatPrice = Convert.ToDecimal(atrip.PerSitPrice);
                }

                foreach (var a in db.TicketSelesDeteils.Where(a => a.TicketSalesInfoTB.TripID == FTripID))
                {
                    if (a.TicketSalesInfoTB.IsSalle == true)
                    {
                        SelectColor(Color.Red, a.BusSitNumber,false);
                    }
                    else
                    {
                        SelectColor(Color.Yellow, a.BusSitNumber, true);
                        

                    }
                }

            }
            cmbGender.Text = "Male";
        }


        private void btnSellSits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(cmbGender.Text))
            {
                MessageBox.Show("Fill All Required File * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            if (dgvSelectedSits.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast 1 Seat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    TicketSalesInfoTB aTicketSalesInfoTB;
                    
                    {
                        aTicketSalesInfoTB = new TicketSalesInfoTB();

                        aTicketSalesInfoTB.Mobile = txtMobile.Text;
                        aTicketSalesInfoTB.CustomerName = txtName.Text;
                        aTicketSalesInfoTB.Email = txtEmail.Text;
                        aTicketSalesInfoTB.Gender = cmbGender.Text;
                        aTicketSalesInfoTB.Age = txtAge.Text;
                        aTicketSalesInfoTB.Address = txtAddress.Text;
                        aTicketSalesInfoTB.Boarding = (int)cmbBoarding.SelectedValue;
                        aTicketSalesInfoTB.Droping = (int)cmbDroping.SelectedValue;
                        aTicketSalesInfoTB.TotalFare = Convert.ToDecimal(labelTotalPayable.Text);
                        aTicketSalesInfoTB.TotalSeat = dgvSelectedSits.Rows.Count;
                        aTicketSalesInfoTB.IsSalle = true;
                        aTicketSalesInfoTB.TripID = FTripID;
                       aTicketSalesInfoTB.BoardingTime = Convert.ToDateTime(txtBoardingTime.Text);
              
                        db.TicketSalesInfoTBs.Add(aTicketSalesInfoTB);

                        
                        if (dgvSelectedSits.Rows.Count > 0)
                        {
                            db.SaveChanges();
                            TicketSelesDeteil aTicketSelesDeteil;
                            foreach (DataGridViewRow dr in dgvSelectedSits.Rows)
                            {

                                aTicketSelesDeteil = new TicketSelesDeteil();

                                aTicketSelesDeteil.TicketSalesInfoID = aTicketSalesInfoTB.ID;
                                aTicketSelesDeteil.BusSitNumber = dr.Cells[0].Value.ToString();
                                aTicketSelesDeteil.SitsPrice = Convert.ToDecimal(dr.Cells[2].Value);
                                db.TicketSelesDeteils.Add(aTicketSelesDeteil);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Save Succesfully");
                            return;
                        }
                        
                        MessageBox.Show("Save Succesfully");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookSits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(cmbGender.Text))
            {
                MessageBox.Show("Fill All Required File * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (dgvSelectedSits.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast 1 Seat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    TicketSalesInfoTB aTicketSalesInfoTB;

                    {
                        aTicketSalesInfoTB = new TicketSalesInfoTB();

                        aTicketSalesInfoTB.Mobile = txtMobile.Text;
                        aTicketSalesInfoTB.CustomerName = txtName.Text;
                        aTicketSalesInfoTB.Email = txtEmail.Text;
                        aTicketSalesInfoTB.Gender = cmbGender.Text;
                        aTicketSalesInfoTB.Age = txtAge.Text;
                        aTicketSalesInfoTB.Address = txtAddress.Text;
                        aTicketSalesInfoTB.Boarding = (int)cmbBoarding.SelectedValue;
                        aTicketSalesInfoTB.Droping = (int)cmbDroping.SelectedValue;
                        aTicketSalesInfoTB.TotalFare = Convert.ToDecimal(labelTotalPayable.Text);
                        aTicketSalesInfoTB.TotalSeat = dgvSelectedSits.Rows.Count;
                        aTicketSalesInfoTB.IsSalle = false;
                        aTicketSalesInfoTB.TripID = FTripID;
                        aTicketSalesInfoTB.BoardingTime = Convert.ToDateTime(txtBoardingTime.Text);

                        db.TicketSalesInfoTBs.Add(aTicketSalesInfoTB);
                        if (dgvSelectedSits.Rows.Count > 0)
                        {
                            db.SaveChanges();
                            TicketSelesDeteil aTicketSelesDeteil;
                            foreach (DataGridViewRow dr in dgvSelectedSits.Rows)
                            {

                                aTicketSelesDeteil = new TicketSelesDeteil();

                                aTicketSelesDeteil.TicketSalesInfoID = aTicketSalesInfoTB.ID;
                                aTicketSelesDeteil.BusSitNumber = dr.Cells[0].Value.ToString();
                                aTicketSelesDeteil.SitsPrice = Convert.ToDecimal(dr.Cells[2].Value);
                                db.TicketSelesDeteils.Add(aTicketSelesDeteil);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Save Succesfully");
                            return;
                        }

                        MessageBox.Show("Save Succesfully");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnBook_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            selectbutton(btnA1);
            //dgvSelectedSits.Rows.Add(cmbAddCounter.SelectedValue, txtSerialNo.Text, cmbAddCounter.Text, txtcounterdistance.Text);
        }

        void selectbutton(Button btn)
        {
            if (btn.BackColor == Color.Green)
            {

                btn.BackColor = Color.White;

                int index = 0;
                for(index=0; index<dgvSelectedSits.Rows.Count; index++)
                {
                    if(dgvSelectedSits.Rows[index].Cells[0].Value.ToString()== btn.Text)
                    {
                        dgvSelectedSits.Rows.RemoveAt(index);
                        labelTotalAmount.Text = ( Convert.ToDecimal(labelTotalAmount.Text)- PerSeatPrice).ToString();
                       
                        break;
                    }
                }
                
            }
            else
            { 
                if(btn.BackColor == Color.Yellow)
                {
                    btnUnBook.Enabled = true;
                    btn.BackColor = Color.Blue;
                    dgvSelectedSits.Rows.Add(btn.Text, cmbBoarding.Text + "   To   " + cmbDroping.Text, PerSeatPrice);
                    labelTotalAmount.Text = (PerSeatPrice + Convert.ToDecimal(labelTotalAmount.Text)).ToString();
                    using (BusDBEntities db = new BusDBEntities())
                    {
                        TicketSelesDeteil aticketSelesDeteil;
                        aticketSelesDeteil = db.TicketSelesDeteils.SingleOrDefault(a=>a.BusSitNumber==btn.Text && a.TicketSalesInfoTB.TripID==FTripID);
                        if(aticketSelesDeteil!=null)
                        {
                            txtMobile.Text = aticketSelesDeteil.TicketSalesInfoTB.Mobile;
                            txtName.Text = aticketSelesDeteil.TicketSalesInfoTB.CustomerName;
                            txtEmail.Text = aticketSelesDeteil.TicketSalesInfoTB.Email;
                            cmbGender.Text = aticketSelesDeteil.TicketSalesInfoTB.Gender;
                            txtAge.Text = aticketSelesDeteil.TicketSalesInfoTB.Age;
                            txtAddress.Text = aticketSelesDeteil.TicketSalesInfoTB.Address;
                        }
                    }

                }
                else if (btn.BackColor == Color.Blue)
                {
                    btnUnBook.Enabled = false;
                    btn.BackColor = Color.Yellow;

                    int index = 0;
                    for (index = 0; index < dgvSelectedSits.Rows.Count; index++)
                    {
                        if (dgvSelectedSits.Rows[index].Cells[0].Value.ToString() == btn.Text)
                        {
                            dgvSelectedSits.Rows.RemoveAt(index);
                            labelTotalAmount.Text = (Convert.ToDecimal(labelTotalAmount.Text) - PerSeatPrice).ToString();

                            break;
                        }
                    }

                }
                else
                {
                    if (dgvSelectedSits.Rows.Count >= 4)
                    {
                        MessageBox.Show("You Can't Select More Then 4 Seats");
                        return;
                    }
                    btn.BackColor = Color.Green;
                    dgvSelectedSits.Rows.Add(btn.Text, cmbBoarding.Text + "   To   " + cmbDroping.Text, PerSeatPrice);
                    labelTotalAmount.Text = (PerSeatPrice + Convert.ToDecimal(labelTotalAmount.Text)).ToString();
                }
            }

            labelTotalPayable.Text = labelTotalAmount.Text;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            selectbutton(btnA2);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            selectbutton(btnA3);
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            selectbutton(btnA4);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            selectbutton(btnB1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            selectbutton(btnB2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            selectbutton(btnB3);
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            selectbutton(btnB4);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            selectbutton(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            selectbutton(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            selectbutton(btnC3);
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            selectbutton(btnC4);
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            selectbutton(btnD1);
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            selectbutton(btnD2);
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            selectbutton(btnD3);
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            selectbutton(btnD4);
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            selectbutton(btnE1);
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            selectbutton(btnE2);
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            selectbutton(btnE3);
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            selectbutton(btnE4);
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            selectbutton(btnF1);
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            selectbutton(btnF2);
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            selectbutton(btnF3);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            selectbutton(btnF4);
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            selectbutton(btnG1);
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            selectbutton(btnG2);
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            selectbutton(btnG3);
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            selectbutton(btnG4);
        }

        private void btnH1_Click(object sender, EventArgs e)
        {
            selectbutton(btnH1);
        }

        private void btnH2_Click(object sender, EventArgs e)
        {
            selectbutton(btnH2);
        }

        private void btnH3_Click(object sender, EventArgs e)
        {
            selectbutton(btnH3);
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            selectbutton(btnH4);
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            selectbutton(btnI1);
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            selectbutton(btnI2);
        }

        private void btnI3_Click(object sender, EventArgs e)
        {
            selectbutton(btnI3);
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            selectbutton(btnI4);
        }

        private void btnJ1_Click(object sender, EventArgs e)
        {
            selectbutton(btnJ1);
        }

        private void btnJ2_Click(object sender, EventArgs e)
        {
            selectbutton(btnJ2);
        }

        private void btnJ3_Click(object sender, EventArgs e)
        {
            selectbutton(btnJ3);
        }

        private void btnJ4_Click(object sender, EventArgs e)
        {
            selectbutton(btnJ4);
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                TicketSalesInfoTB aTicketSale;
                aTicketSale = db.TicketSalesInfoTBs.SingleOrDefault(a => a.Mobile == txtMobile.Text);

                if(aTicketSale != null)
                {
                    txtName.Text = aTicketSale.CustomerName;
                    txtEmail.Text = aTicketSale.Email;
                    cmbGender.Text = aTicketSale.Gender;
                    txtAge.Text = aTicketSale.Age;
                    txtAddress.Text = aTicketSale.Address;
                }
            }
        }
    }
}
