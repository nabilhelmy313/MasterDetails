using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class QAFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public QAFrm()
        {
            InitializeComponent();
            answerBindingSource.DataSource = db.Answers.Local.ToBindingList();
            db.Answers.Load();
            questionBindingSource.DataSource = db.Answers.ToList();
        }
    }
}