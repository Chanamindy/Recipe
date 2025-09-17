using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new();
        int recipeid;
        string recipestatus;
        private enum RecipeStatusEnum { Drafted, Published, Archived };
        RecipeStatusEnum currentstatus = RecipeStatusEnum.Drafted;
        
        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
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
            EnableDisableButtons();
        }

        private void ChangeRecipeStatus(int recipeid, string newstatus)
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
                    Recipe.ChangeRecipeStatus(recipeid, newstatus);
                    dtRecipe = Recipe.Load(recipeid);
                    recipestatus = dtRecipe.Rows[0]["RecipeStatus"].ToString();
                    bindsource.DataSource = dtRecipe;
                    EnableDisableButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void EnableDisableButtons()
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
            ChangeRecipeStatus(recipeid, "Archive");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(recipeid, "Publish");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(recipeid, "Draft");
        }
    }
}
