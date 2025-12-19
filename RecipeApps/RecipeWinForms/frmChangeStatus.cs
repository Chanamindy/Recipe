namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new();
        int recipeid;
        string recipestatus;
        
        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
            this.FormClosing += FrmChangeStatus_FormClosing;
        }

        private void FrmChangeStatus_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), recipeid);
            }
        }

        public void OpenForm(int RecipeId, string RecipeStatus)
        {
            recipeid = RecipeId;
            recipestatus = RecipeStatus;
            BindData();
        }

        private void BindData()
        {
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            EnableDisableButtons(recipestatus);
        }

        private void ChangeRecipeStatus(int recipeid, string recipestatus, string newstatus)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to " + newstatus + " this recipe?", "Recipe", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Recipe.ChangeRecipeStatus(recipeid, recipestatus, newstatus);
                    dtRecipe = Recipe.Load(recipeid);
                    recipestatus = dtRecipe.Rows[0]["RecipeStatus"].ToString();
                    bindsource.DataSource = dtRecipe;
                    EnableDisableButtons(recipestatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void EnableDisableButtons(string recipestatus)
        {
            bool bdrafted = recipestatus == "Drafted" ? false : true;
            bool bpublished = recipestatus == "Published" ? false : true;
            bool barchived = recipestatus == "Archived" ? false : true;
            btnDraft.Enabled = bdrafted;
            btnPublish.Enabled = bpublished;
            btnArchive.Enabled = barchived;
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(recipeid, recipestatus, "Archive");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(recipeid, recipestatus, "Publish");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(recipeid, recipestatus, "Draft");
        }
    }
}
