﻿
namespace Projet_Onssa
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_content = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cnx = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_banner = new System.Windows.Forms.Panel();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_content.Controls.Add(this.label4);
            this.panel_content.Controls.Add(this.bunifuCheckbox1);
            this.panel_content.Controls.Add(this.label3);
            this.panel_content.Controls.Add(this.label2);
            this.panel_content.Controls.Add(this.label1);
            this.panel_content.Controls.Add(this.btn_Cnx);
            this.panel_content.Controls.Add(this.bunifuMaterialTextbox3);
            this.panel_content.Controls.Add(this.bunifuMaterialTextbox4);
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(382, 485);
            this.panel_content.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(62, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Keep me logged in";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Gainsboro;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(36, 354);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(33, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(33, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign In";
            // 
            // btn_Cnx
            // 
            this.btn_Cnx.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Cnx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.btn_Cnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cnx.BorderRadius = 7;
            this.btn_Cnx.ButtonText = "Sign In";
            this.btn_Cnx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cnx.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cnx.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cnx.Iconimage = null;
            this.btn_Cnx.Iconimage_right = null;
            this.btn_Cnx.Iconimage_right_Selected = null;
            this.btn_Cnx.Iconimage_Selected = null;
            this.btn_Cnx.IconMarginLeft = 0;
            this.btn_Cnx.IconMarginRight = 0;
            this.btn_Cnx.IconRightVisible = true;
            this.btn_Cnx.IconRightZoom = 0D;
            this.btn_Cnx.IconVisible = true;
            this.btn_Cnx.IconZoom = 90D;
            this.btn_Cnx.IsTab = false;
            this.btn_Cnx.Location = new System.Drawing.Point(111, 394);
            this.btn_Cnx.Name = "btn_Cnx";
            this.btn_Cnx.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.btn_Cnx.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Cnx.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cnx.selected = false;
            this.btn_Cnx.Size = new System.Drawing.Size(142, 48);
            this.btn_Cnx.TabIndex = 11;
            this.btn_Cnx.Text = "Sign In";
            this.btn_Cnx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cnx.Textcolor = System.Drawing.Color.White;
            this.btn_Cnx.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = true;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(36, 275);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(284, 44);
            this.bunifuMaterialTextbox3.TabIndex = 10;
            this.bunifuMaterialTextbox3.Text = "Password";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(36, 183);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(284, 44);
            this.bunifuMaterialTextbox4.TabIndex = 9;
            this.bunifuMaterialTextbox4.Text = "you.example@zaka.com";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel_banner
            // 
            this.panel_banner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(75)))));
            this.panel_banner.BackgroundImage = global::Projet_Onssa.Properties.Resources.banner;
            this.panel_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_banner.Location = new System.Drawing.Point(381, 0);
            this.panel_banner.Name = "panel_banner";
            this.panel_banner.Size = new System.Drawing.Size(431, 485);
            this.panel_banner.TabIndex = 0;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 485);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(998, 694);
            this.MinimumSize = new System.Drawing.Size(828, 524);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_banner;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cnx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

