﻿using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
{
    partial class GameTrainersDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameTrainersDialog));
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.GridControlCheats = new DevExpress.XtraGrid.GridControl();
            this.GridViewCheats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelGame = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitleId = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallTrainer = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReportIssue = new DevExpress.XtraEditors.SimpleButton();
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).BeginInit();
            this.PanelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PanelDetails.Appearance.Options.UseBackColor = true;
            this.PanelDetails.Controls.Add(this.GridControlCheats);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 50);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(650, 300);
            this.PanelDetails.TabIndex = 1;
            // 
            // GridControlCheats
            // 
            this.GridControlCheats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlCheats.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GridControlCheats.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridControlCheats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlCheats.Location = new System.Drawing.Point(16, 3);
            this.GridControlCheats.MainView = this.GridViewCheats;
            this.GridControlCheats.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GridControlCheats.Name = "GridControlCheats";
            this.GridControlCheats.Size = new System.Drawing.Size(620, 297);
            this.GridControlCheats.TabIndex = 6;
            this.GridControlCheats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCheats});
            // 
            // GridViewCheats
            // 
            this.GridViewCheats.ActiveFilterEnabled = false;
            this.GridViewCheats.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GridViewCheats.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GridViewCheats.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.Appearance.Row.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.Options.UseFont = true;
            this.GridViewCheats.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewCheats.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewCheats.GridControl = this.GridControlCheats;
            this.GridViewCheats.GroupRowHeight = 20;
            this.GridViewCheats.Name = "GridViewCheats";
            this.GridViewCheats.OptionsBehavior.Editable = false;
            this.GridViewCheats.OptionsBehavior.ReadOnly = true;
            this.GridViewCheats.OptionsCustomization.AllowFilter = false;
            this.GridViewCheats.OptionsFilter.AllowFilterEditor = false;
            this.GridViewCheats.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewCheats.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewCheats.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewCheats.OptionsView.ShowColumnHeaders = false;
            this.GridViewCheats.OptionsView.ShowGroupPanel = false;
            this.GridViewCheats.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsView.ShowIndicator = false;
            this.GridViewCheats.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.RowHeight = 24;
            this.GridViewCheats.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewCheats_RowClick);
            this.GridViewCheats.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewCheats_FocusedRowChanged);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageClose);
            this.PanelHeader.Controls.Add(this.PanelRegion);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(650, 50);
            this.PanelHeader.TabIndex = 1190;
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 40);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(650, 10);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageClose
            // 
            this.ImageClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageClose.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageClose.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageClose.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageClose.Location = new System.Drawing.Point(613, 10);
            this.ImageClose.Name = "ImageClose";
            this.ImageClose.Size = new System.Drawing.Size(26, 26);
            this.ImageClose.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageClose.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageClose.SvgImage")));
            this.ImageClose.TabIndex = 1171;
            this.ImageClose.Text = "Close";
            this.ImageClose.Click += new System.EventHandler(this.ImageClose_Click);
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelGame);
            this.PanelRegion.Controls.Add(this.LabelTitleId);
            this.PanelRegion.Location = new System.Drawing.Point(16, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(591, 22);
            this.PanelRegion.TabIndex = 1190;
            this.PanelRegion.WrapContents = false;
            // 
            // LabelGame
            // 
            this.LabelGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGame.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelGame.Appearance.Options.UseFont = true;
            this.LabelGame.AutoEllipsis = true;
            this.LabelGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGame.Location = new System.Drawing.Point(0, 1);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(35, 17);
            this.LabelGame.TabIndex = 1184;
            this.LabelGame.Text = "Game";
            // 
            // LabelTitleId
            // 
            this.LabelTitleId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleId.Appearance.Options.UseFont = true;
            this.LabelTitleId.AutoEllipsis = true;
            this.LabelTitleId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleId.Location = new System.Drawing.Point(41, 3);
            this.LabelTitleId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelTitleId.Name = "LabelTitleId";
            this.LabelTitleId.Size = new System.Drawing.Size(44, 15);
            this.LabelTitleId.TabIndex = 1170;
            this.LabelTitleId.Text = "(TitleId)";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonInstallTrainer);
            this.PanelActions.Controls.Add(this.ButtonReportIssue);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 350);
            this.PanelActions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(650, 50);
            this.PanelActions.TabIndex = 1175;
            // 
            // ButtonInstallTrainer
            // 
            this.ButtonInstallTrainer.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInstallTrainer.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonInstallTrainer.Appearance.Options.UseFont = true;
            this.ButtonInstallTrainer.Appearance.Options.UseForeColor = true;
            this.ButtonInstallTrainer.AutoSize = true;
            this.ButtonInstallTrainer.Enabled = false;
            this.ButtonInstallTrainer.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInstallTrainer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstallTrainer.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstallTrainer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstallTrainer.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_install;
            this.ButtonInstallTrainer.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonInstallTrainer.Location = new System.Drawing.Point(12, 11);
            this.ButtonInstallTrainer.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.ButtonInstallTrainer.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonInstallTrainer.Name = "ButtonInstallTrainer";
            this.ButtonInstallTrainer.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstallTrainer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallTrainer.Size = new System.Drawing.Size(133, 28);
            this.ButtonInstallTrainer.TabIndex = 1176;
            this.ButtonInstallTrainer.Text = "Install Trainer";
            this.ButtonInstallTrainer.Click += new System.EventHandler(this.ButtonInstallTrainer_Click);
            // 
            // ButtonReportIssue
            // 
            this.ButtonReportIssue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonReportIssue.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonReportIssue.Appearance.Options.UseFont = true;
            this.ButtonReportIssue.Appearance.Options.UseForeColor = true;
            this.ButtonReportIssue.AutoSize = true;
            this.ButtonReportIssue.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonReportIssue.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonReportIssue.ImageOptions.ImageToTextIndent = 6;
            this.ButtonReportIssue.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonReportIssue.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonReportIssue.ImageOptions.SvgImage")));
            this.ButtonReportIssue.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonReportIssue.Location = new System.Drawing.Point(153, 11);
            this.ButtonReportIssue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReportIssue.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonReportIssue.Name = "ButtonReportIssue";
            this.ButtonReportIssue.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonReportIssue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReportIssue.Size = new System.Drawing.Size(127, 28);
            this.ButtonReportIssue.TabIndex = 1177;
            this.ButtonReportIssue.Text = "Report Issue";
            this.ButtonReportIssue.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // GameTrainersDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameTrainersDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GameTrainersDialog_Load);
            this.PanelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).EndInit();
            this.PanelRegion.ResumeLayout(false);
            this.PanelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.PanelActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelDetails;
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private SimpleButton ButtonInstallTrainer;
        private SimpleButton ButtonReportIssue;
        private LabelControl LabelGame;
        private PanelControl PanelHeader;
        private SvgImageBox ImageClose;
        private SeparatorControl SeparatorHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private DevExpress.XtraGrid.GridControl GridControlCheats;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewCheats;
        private LabelControl LabelTitleId;
    }
}