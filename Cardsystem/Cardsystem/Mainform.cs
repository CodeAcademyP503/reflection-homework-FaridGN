using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardsystem.Core;
using Cardsystem.Models;

namespace Cardsystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card()
            {
                Number = Convert.ToInt32(textBox1.Text)
            };

            using (Database db = new InMemoryDatabase())
            {
                db.Cards.Add(new Card
                {
                    Id = 1,
                    Number = 12345,
                    Isused = false,
                    Balance = 45,
                    CurrencyType = CurrencyType.USD,
                    AddedDate = DateTime.Now

                });
                 Card existedCard = db.Cards.Exists(card);
                if (existedCard != null)
                {
                    AppUser appUser = new AppUser()
                    {
                        Email = "user01@example.com",
                        Name = "user_010245",
                        Password = "user_2145632",
                        MobileNum = "11111111",
                        Role = RoleType.User,
                        Balance = existedCard.Balance
                    };

                    AppUser addeduser = db.Users.Add(appUser);

                    if (addeduser != null)
                    {
                        existedCard.ActivatedBy = addeduser;
                        existedCard.ActivatedById = addeduser.Id;
                        db.Cards.Update(existedCard);
                    }
                    existedCard.Isused = true;
                    existedCard.ActivatedDate = DateTime.Now;

                    db.Cards.Update(existedCard);
                }

               
            }
        }

  
    }
}
