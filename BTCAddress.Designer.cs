
namespace BitCoin_Address
{
    partial class BTCAddress
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeedToSHA256 = new System.Windows.Forms.Label();
            this.txtSeedToSHA256 = new System.Windows.Forms.TextBox();
            this.btnSeedToSHA256 = new System.Windows.Forms.Button();
            this.lblPrivHex = new System.Windows.Forms.Label();
            this.txtPrivHex = new System.Windows.Forms.TextBox();
            this.btnPrivToWIF = new System.Windows.Forms.Button();
            this.lblPrivWIF = new System.Windows.Forms.Label();
            this.txtPrivWIF = new System.Windows.Forms.TextBox();
            this.btnPrivWIFToHex = new System.Windows.Forms.Button();
            this.btnPrivToPub = new System.Windows.Forms.Button();
            this.lblPubHex = new System.Windows.Forms.Label();
            this.txtPubHex = new System.Windows.Forms.TextBox();
            this.btnGenPri = new System.Windows.Forms.Button();
            this.btnPubHexToSha = new System.Windows.Forms.Button();
            this.lblPubSha256 = new System.Windows.Forms.Label();
            this.txtPubSha256 = new System.Windows.Forms.TextBox();
            this.btnPubShaToRipemd = new System.Windows.Forms.Button();
            this.lblPubRipemd160 = new System.Windows.Forms.Label();
            this.txtPubRipemd160 = new System.Windows.Forms.TextBox();
            this.lblBtcAddress = new System.Windows.Forms.Label();
            this.txtBtcAddress = new System.Windows.Forms.TextBox();
            this.btnAddToPubRip = new System.Windows.Forms.Button();
            this.btnPubRipToAdd = new System.Windows.Forms.Button();
            this.cboCoinType = new System.Windows.Forms.ComboBox();
            this.lblBtcNetWork = new System.Windows.Forms.Label();
            this.btnBlockExplorer = new System.Windows.Forms.Button();
            this.lblPubKeyPointX = new System.Windows.Forms.Label();
            this.txtPubKeyPointX = new System.Windows.Forms.TextBox();
            this.lblPubKeyPointY = new System.Windows.Forms.Label();
            this.txtPubKeyPointY = new System.Windows.Forms.TextBox();
            this.lblBtclNetwork = new System.Windows.Forms.Label();
            this.txtBtclNetwork = new System.Windows.Forms.TextBox();
            this.btnECDSADec = new System.Windows.Forms.Button();
            this.btnPubToPriv = new System.Windows.Forms.Button();
            this.lblPriKeyDec = new System.Windows.Forms.Label();
            this.txtPriKeyDec = new System.Windows.Forms.TextBox();
            this.btnECDSAHex = new System.Windows.Forms.Button();
            this.btnDecodeTxIdKeys = new System.Windows.Forms.Button();
            this.btnTxID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeedToSHA256
            // 
            this.lblSeedToSHA256.AutoSize = true;
            this.lblSeedToSHA256.Location = new System.Drawing.Point(12, 43);
            this.lblSeedToSHA256.Name = "lblSeedToSHA256";
            this.lblSeedToSHA256.Size = new System.Drawing.Size(124, 15);
            this.lblSeedToSHA256.TabIndex = 0;
            this.lblSeedToSHA256.Text = "Text to Hash (SHA256)";
            // 
            // txtSeedToSHA256
            // 
            this.txtSeedToSHA256.Location = new System.Drawing.Point(182, 34);
            this.txtSeedToSHA256.Multiline = true;
            this.txtSeedToSHA256.Name = "txtSeedToSHA256";
            this.txtSeedToSHA256.Size = new System.Drawing.Size(572, 49);
            this.txtSeedToSHA256.TabIndex = 2;
            // 
            // btnSeedToSHA256
            // 
            this.btnSeedToSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeedToSHA256.ForeColor = System.Drawing.Color.Black;
            this.btnSeedToSHA256.Location = new System.Drawing.Point(761, 60);
            this.btnSeedToSHA256.Name = "btnSeedToSHA256";
            this.btnSeedToSHA256.Size = new System.Drawing.Size(75, 23);
            this.btnSeedToSHA256.TabIndex = 3;
            this.btnSeedToSHA256.Text = "▼ PriHex";
            this.btnSeedToSHA256.UseVisualStyleBackColor = true;
            this.btnSeedToSHA256.Click += new System.EventHandler(this.btnSeedToSHA256_Click);
            // 
            // lblPrivHex
            // 
            this.lblPrivHex.AutoSize = true;
            this.lblPrivHex.Location = new System.Drawing.Point(11, 95);
            this.lblPrivHex.Name = "lblPrivHex";
            this.lblPrivHex.Size = new System.Drawing.Size(136, 15);
            this.lblPrivHex.TabIndex = 3;
            this.lblPrivHex.Text = "Private Key (Hex) ECDSA";
            // 
            // txtPrivHex
            // 
            this.txtPrivHex.Location = new System.Drawing.Point(182, 95);
            this.txtPrivHex.Name = "txtPrivHex";
            this.txtPrivHex.Size = new System.Drawing.Size(572, 23);
            this.txtPrivHex.TabIndex = 4;
            this.txtPrivHex.TextChanged += new System.EventHandler(this.txtPrivHex_TextChanged);
            // 
            // btnPrivToWIF
            // 
            this.btnPrivToWIF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrivToWIF.Location = new System.Drawing.Point(761, 95);
            this.btnPrivToWIF.Name = "btnPrivToWIF";
            this.btnPrivToWIF.Size = new System.Drawing.Size(75, 23);
            this.btnPrivToWIF.TabIndex = 5;
            this.btnPrivToWIF.Text = "▼ PriWIF";
            this.btnPrivToWIF.UseVisualStyleBackColor = true;
            this.btnPrivToWIF.Click += new System.EventHandler(this.btnPrivToWIF_Click);
            // 
            // lblPrivWIF
            // 
            this.lblPrivWIF.AutoSize = true;
            this.lblPrivWIF.Location = new System.Drawing.Point(12, 132);
            this.lblPrivWIF.Name = "lblPrivWIF";
            this.lblPrivWIF.Size = new System.Drawing.Size(96, 15);
            this.lblPrivWIF.TabIndex = 6;
            this.lblPrivWIF.Text = "Private Key (WIF)";
            // 
            // txtPrivWIF
            // 
            this.txtPrivWIF.Location = new System.Drawing.Point(182, 132);
            this.txtPrivWIF.Name = "txtPrivWIF";
            this.txtPrivWIF.Size = new System.Drawing.Size(491, 23);
            this.txtPrivWIF.TabIndex = 6;
            // 
            // btnPrivWIFToHex
            // 
            this.btnPrivWIFToHex.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrivWIFToHex.Location = new System.Drawing.Point(679, 132);
            this.btnPrivWIFToHex.Name = "btnPrivWIFToHex";
            this.btnPrivWIFToHex.Size = new System.Drawing.Size(75, 23);
            this.btnPrivWIFToHex.TabIndex = 7;
            this.btnPrivWIFToHex.Text = "▲ PriWIF";
            this.btnPrivWIFToHex.UseVisualStyleBackColor = true;
            this.btnPrivWIFToHex.Click += new System.EventHandler(this.btnPrivWIFToHex_Click);
            // 
            // btnPrivToPub
            // 
            this.btnPrivToPub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrivToPub.Location = new System.Drawing.Point(761, 132);
            this.btnPrivToPub.Name = "btnPrivToPub";
            this.btnPrivToPub.Size = new System.Drawing.Size(75, 23);
            this.btnPrivToPub.TabIndex = 8;
            this.btnPrivToPub.Text = "▼ PubHex";
            this.btnPrivToPub.UseVisualStyleBackColor = true;
            this.btnPrivToPub.Click += new System.EventHandler(this.btnPrivToPub_Click);
            // 
            // lblPubHex
            // 
            this.lblPubHex.AutoSize = true;
            this.lblPubHex.Location = new System.Drawing.Point(12, 172);
            this.lblPubHex.Name = "lblPubHex";
            this.lblPubHex.Size = new System.Drawing.Size(133, 15);
            this.lblPubHex.TabIndex = 10;
            this.lblPubHex.Text = "Public Key (Hex) ECDSA";
            // 
            // txtPubHex
            // 
            this.txtPubHex.Location = new System.Drawing.Point(182, 169);
            this.txtPubHex.Multiline = true;
            this.txtPubHex.Name = "txtPubHex";
            this.txtPubHex.Size = new System.Drawing.Size(572, 53);
            this.txtPubHex.TabIndex = 9;
            this.txtPubHex.TextChanged += new System.EventHandler(this.txtPubHex_TextChanged);
            // 
            // btnGenPri
            // 
            this.btnGenPri.Location = new System.Drawing.Point(12, 61);
            this.btnGenPri.Name = "btnGenPri";
            this.btnGenPri.Size = new System.Drawing.Size(124, 23);
            this.btnGenPri.TabIndex = 1;
            this.btnGenPri.Text = "▼ RANDOM PriHex";
            this.btnGenPri.UseVisualStyleBackColor = true;
            this.btnGenPri.Click += new System.EventHandler(this.btnGenPri_Click);
            // 
            // btnPubHexToSha
            // 
            this.btnPubHexToSha.Location = new System.Drawing.Point(760, 168);
            this.btnPubHexToSha.Name = "btnPubHexToSha";
            this.btnPubHexToSha.Size = new System.Drawing.Size(75, 23);
            this.btnPubHexToSha.TabIndex = 10;
            this.btnPubHexToSha.Text = "▼ PubSha";
            this.btnPubHexToSha.UseVisualStyleBackColor = true;
            this.btnPubHexToSha.Click += new System.EventHandler(this.btnPubHexToSha_Click);
            // 
            // lblPubSha256
            // 
            this.lblPubSha256.AutoSize = true;
            this.lblPubSha256.Location = new System.Drawing.Point(12, 242);
            this.lblPubSha256.Name = "lblPubSha256";
            this.lblPubSha256.Size = new System.Drawing.Size(144, 15);
            this.lblPubSha256.TabIndex = 14;
            this.lblPubSha256.Text = "Public Key (Hash) SHA256";
            // 
            // txtPubSha256
            // 
            this.txtPubSha256.Location = new System.Drawing.Point(182, 239);
            this.txtPubSha256.Name = "txtPubSha256";
            this.txtPubSha256.Size = new System.Drawing.Size(572, 23);
            this.txtPubSha256.TabIndex = 11;
            this.txtPubSha256.TextChanged += new System.EventHandler(this.txtPubSha256_TextChanged);
            // 
            // btnPubShaToRipemd
            // 
            this.btnPubShaToRipemd.Location = new System.Drawing.Point(761, 239);
            this.btnPubShaToRipemd.Name = "btnPubShaToRipemd";
            this.btnPubShaToRipemd.Size = new System.Drawing.Size(75, 23);
            this.btnPubShaToRipemd.TabIndex = 12;
            this.btnPubShaToRipemd.Text = "▼ PubRipe";
            this.btnPubShaToRipemd.UseVisualStyleBackColor = true;
            this.btnPubShaToRipemd.Click += new System.EventHandler(this.btnPubShaToRipemd_Click);
            // 
            // lblPubRipemd160
            // 
            this.lblPubRipemd160.AutoSize = true;
            this.lblPubRipemd160.Location = new System.Drawing.Point(12, 277);
            this.lblPubRipemd160.Name = "lblPubRipemd160";
            this.lblPubRipemd160.Size = new System.Drawing.Size(163, 15);
            this.lblPubRipemd160.TabIndex = 17;
            this.lblPubRipemd160.Text = "Public Key (Hash) RIPEMD160";
            // 
            // txtPubRipemd160
            // 
            this.txtPubRipemd160.Location = new System.Drawing.Point(181, 274);
            this.txtPubRipemd160.Name = "txtPubRipemd160";
            this.txtPubRipemd160.Size = new System.Drawing.Size(573, 23);
            this.txtPubRipemd160.TabIndex = 13;
            this.txtPubRipemd160.TextChanged += new System.EventHandler(this.txtPubRipemd160_TextChanged);
            // 
            // lblBtcAddress
            // 
            this.lblBtcAddress.AutoSize = true;
            this.lblBtcAddress.Location = new System.Drawing.Point(12, 314);
            this.lblBtcAddress.Name = "lblBtcAddress";
            this.lblBtcAddress.Size = new System.Drawing.Size(141, 15);
            this.lblBtcAddress.TabIndex = 19;
            this.lblBtcAddress.Text = "Address Base58 encoding";
            // 
            // txtBtcAddress
            // 
            this.txtBtcAddress.Location = new System.Drawing.Point(181, 311);
            this.txtBtcAddress.Name = "txtBtcAddress";
            this.txtBtcAddress.Size = new System.Drawing.Size(492, 23);
            this.txtBtcAddress.TabIndex = 15;
            // 
            // btnAddToPubRip
            // 
            this.btnAddToPubRip.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddToPubRip.Location = new System.Drawing.Point(679, 311);
            this.btnAddToPubRip.Name = "btnAddToPubRip";
            this.btnAddToPubRip.Size = new System.Drawing.Size(75, 23);
            this.btnAddToPubRip.TabIndex = 16;
            this.btnAddToPubRip.Text = "▲ AddrPub";
            this.btnAddToPubRip.UseVisualStyleBackColor = true;
            this.btnAddToPubRip.Click += new System.EventHandler(this.btnAddToPubRip_Click);
            // 
            // btnPubRipToAdd
            // 
            this.btnPubRipToAdd.Location = new System.Drawing.Point(761, 274);
            this.btnPubRipToAdd.Name = "btnPubRipToAdd";
            this.btnPubRipToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPubRipToAdd.TabIndex = 14;
            this.btnPubRipToAdd.Text = "▼ PubAddr";
            this.btnPubRipToAdd.UseVisualStyleBackColor = true;
            this.btnPubRipToAdd.Click += new System.EventHandler(this.btnPubRipToAdd_Click);
            // 
            // cboCoinType
            // 
            this.cboCoinType.FormattingEnabled = true;
            this.cboCoinType.Items.AddRange(new object[] {
            "Bitcoin",
            "Testnet",
            "Namecoin"});
            this.cboCoinType.Location = new System.Drawing.Point(503, 354);
            this.cboCoinType.Name = "cboCoinType";
            this.cboCoinType.Size = new System.Drawing.Size(121, 23);
            this.cboCoinType.TabIndex = 17;
            // 
            // lblBtcNetWork
            // 
            this.lblBtcNetWork.AutoSize = true;
            this.lblBtcNetWork.Location = new System.Drawing.Point(422, 358);
            this.lblBtcNetWork.Name = "lblBtcNetWork";
            this.lblBtcNetWork.Size = new System.Drawing.Size(76, 15);
            this.lblBtcNetWork.TabIndex = 24;
            this.lblBtcNetWork.Text = "BTC NetWork";
            // 
            // btnBlockExplorer
            // 
            this.btnBlockExplorer.Location = new System.Drawing.Point(630, 354);
            this.btnBlockExplorer.Name = "btnBlockExplorer";
            this.btnBlockExplorer.Size = new System.Drawing.Size(124, 23);
            this.btnBlockExplorer.TabIndex = 18;
            this.btnBlockExplorer.Text = "Block Explorer";
            this.btnBlockExplorer.UseVisualStyleBackColor = true;
            this.btnBlockExplorer.Click += new System.EventHandler(this.btnBlockExplorer_Click);
            // 
            // lblPubKeyPointX
            // 
            this.lblPubKeyPointX.AutoSize = true;
            this.lblPubKeyPointX.Location = new System.Drawing.Point(93, 389);
            this.lblPubKeyPointX.Name = "lblPubKeyPointX";
            this.lblPubKeyPointX.Size = new System.Drawing.Size(94, 15);
            this.lblPubKeyPointX.TabIndex = 26;
            this.lblPubKeyPointX.Text = "Pub Key [Dec] X:";
            // 
            // txtPubKeyPointX
            // 
            this.txtPubKeyPointX.Location = new System.Drawing.Point(193, 386);
            this.txtPubKeyPointX.Name = "txtPubKeyPointX";
            this.txtPubKeyPointX.ReadOnly = true;
            this.txtPubKeyPointX.Size = new System.Drawing.Size(561, 23);
            this.txtPubKeyPointX.TabIndex = 27;
            // 
            // lblPubKeyPointY
            // 
            this.lblPubKeyPointY.AutoSize = true;
            this.lblPubKeyPointY.Location = new System.Drawing.Point(93, 418);
            this.lblPubKeyPointY.Name = "lblPubKeyPointY";
            this.lblPubKeyPointY.Size = new System.Drawing.Size(94, 15);
            this.lblPubKeyPointY.TabIndex = 28;
            this.lblPubKeyPointY.Text = "Pub Key [Dec] Y:";
            // 
            // txtPubKeyPointY
            // 
            this.txtPubKeyPointY.Location = new System.Drawing.Point(193, 415);
            this.txtPubKeyPointY.Name = "txtPubKeyPointY";
            this.txtPubKeyPointY.ReadOnly = true;
            this.txtPubKeyPointY.Size = new System.Drawing.Size(561, 23);
            this.txtPubKeyPointY.TabIndex = 29;
            // 
            // lblBtclNetwork
            // 
            this.lblBtclNetwork.AutoSize = true;
            this.lblBtclNetwork.Location = new System.Drawing.Point(93, 359);
            this.lblBtclNetwork.Name = "lblBtclNetwork";
            this.lblBtclNetwork.Size = new System.Drawing.Size(84, 15);
            this.lblBtclNetwork.TabIndex = 30;
            this.lblBtclNetwork.Text = "Network (Hex)";
            // 
            // txtBtclNetwork
            // 
            this.txtBtclNetwork.Location = new System.Drawing.Point(193, 356);
            this.txtBtclNetwork.Name = "txtBtclNetwork";
            this.txtBtclNetwork.ReadOnly = true;
            this.txtBtclNetwork.Size = new System.Drawing.Size(58, 23);
            this.txtBtclNetwork.TabIndex = 31;
            // 
            // btnECDSADec
            // 
            this.btnECDSADec.Location = new System.Drawing.Point(12, 355);
            this.btnECDSADec.Name = "btnECDSADec";
            this.btnECDSADec.Size = new System.Drawing.Size(75, 23);
            this.btnECDSADec.TabIndex = 32;
            this.btnECDSADec.Text = "ECDSA Dec";
            this.btnECDSADec.UseVisualStyleBackColor = true;
            this.btnECDSADec.Click += new System.EventHandler(this.btnPubHexPoint_Click);
            // 
            // btnPubToPriv
            // 
            this.btnPubToPriv.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPubToPriv.Location = new System.Drawing.Point(760, 199);
            this.btnPubToPriv.Name = "btnPubToPriv";
            this.btnPubToPriv.Size = new System.Drawing.Size(75, 23);
            this.btnPubToPriv.TabIndex = 33;
            this.btnPubToPriv.Text = "▲ PubPri";
            this.btnPubToPriv.UseVisualStyleBackColor = true;
            this.btnPubToPriv.Click += new System.EventHandler(this.btnPubToPriv_Click);
            // 
            // lblPriKeyDec
            // 
            this.lblPriKeyDec.AutoSize = true;
            this.lblPriKeyDec.BackColor = System.Drawing.Color.Transparent;
            this.lblPriKeyDec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriKeyDec.ForeColor = System.Drawing.Color.Maroon;
            this.lblPriKeyDec.Location = new System.Drawing.Point(95, 451);
            this.lblPriKeyDec.Name = "lblPriKeyDec";
            this.lblPriKeyDec.Size = new System.Drawing.Size(82, 15);
            this.lblPriKeyDec.TabIndex = 34;
            this.lblPriKeyDec.Text = "Pri Key (Dec):";
            // 
            // txtPriKeyDec
            // 
            this.txtPriKeyDec.ForeColor = System.Drawing.Color.Maroon;
            this.txtPriKeyDec.Location = new System.Drawing.Point(193, 448);
            this.txtPriKeyDec.Name = "txtPriKeyDec";
            this.txtPriKeyDec.ReadOnly = true;
            this.txtPriKeyDec.Size = new System.Drawing.Size(561, 23);
            this.txtPriKeyDec.TabIndex = 35;
            // 
            // btnECDSAHex
            // 
            this.btnECDSAHex.Location = new System.Drawing.Point(12, 385);
            this.btnECDSAHex.Name = "btnECDSAHex";
            this.btnECDSAHex.Size = new System.Drawing.Size(75, 23);
            this.btnECDSAHex.TabIndex = 36;
            this.btnECDSAHex.Text = "ECDSA Hex";
            this.btnECDSAHex.UseVisualStyleBackColor = true;
            this.btnECDSAHex.Click += new System.EventHandler(this.btnECDSAHex_Click);
            // 
            // btnDecodeTxIdKeys
            // 
            this.btnDecodeTxIdKeys.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDecodeTxIdKeys.Location = new System.Drawing.Point(12, 12);
            this.btnDecodeTxIdKeys.Name = "btnDecodeTxIdKeys";
            this.btnDecodeTxIdKeys.Size = new System.Drawing.Size(125, 23);
            this.btnDecodeTxIdKeys.TabIndex = 37;
            this.btnDecodeTxIdKeys.Text = "Decode TxID";
            this.btnDecodeTxIdKeys.UseVisualStyleBackColor = true;
            this.btnDecodeTxIdKeys.Click += new System.EventHandler(this.btnDecodeTxIdKeys_Click);
            // 
            // btnTxID
            // 
            this.btnTxID.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTxID.Location = new System.Drawing.Point(760, 34);
            this.btnTxID.Name = "btnTxID";
            this.btnTxID.Size = new System.Drawing.Size(75, 23);
            this.btnTxID.TabIndex = 38;
            this.btnTxID.Text = "▼ TxID";
            this.btnTxID.UseVisualStyleBackColor = true;
            this.btnTxID.Visible = false;
            //this.btnTxID.Click += new System.EventHandler(this.btnTxID_Click);
            // 
            // BTCAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 484);
            this.Controls.Add(this.btnTxID);
            this.Controls.Add(this.btnDecodeTxIdKeys);
            this.Controls.Add(this.btnECDSAHex);
            this.Controls.Add(this.txtPriKeyDec);
            this.Controls.Add(this.lblPriKeyDec);
            this.Controls.Add(this.btnPubToPriv);
            this.Controls.Add(this.btnECDSADec);
            this.Controls.Add(this.txtBtclNetwork);
            this.Controls.Add(this.lblBtclNetwork);
            this.Controls.Add(this.txtPubKeyPointY);
            this.Controls.Add(this.lblPubKeyPointY);
            this.Controls.Add(this.txtPubKeyPointX);
            this.Controls.Add(this.lblPubKeyPointX);
            this.Controls.Add(this.btnBlockExplorer);
            this.Controls.Add(this.lblBtcNetWork);
            this.Controls.Add(this.cboCoinType);
            this.Controls.Add(this.btnPubRipToAdd);
            this.Controls.Add(this.btnAddToPubRip);
            this.Controls.Add(this.txtBtcAddress);
            this.Controls.Add(this.lblBtcAddress);
            this.Controls.Add(this.txtPubRipemd160);
            this.Controls.Add(this.lblPubRipemd160);
            this.Controls.Add(this.btnPubShaToRipemd);
            this.Controls.Add(this.txtPubSha256);
            this.Controls.Add(this.lblPubSha256);
            this.Controls.Add(this.btnPubHexToSha);
            this.Controls.Add(this.btnGenPri);
            this.Controls.Add(this.txtPubHex);
            this.Controls.Add(this.lblPubHex);
            this.Controls.Add(this.btnPrivToPub);
            this.Controls.Add(this.btnPrivWIFToHex);
            this.Controls.Add(this.txtPrivWIF);
            this.Controls.Add(this.lblPrivWIF);
            this.Controls.Add(this.btnPrivToWIF);
            this.Controls.Add(this.txtPrivHex);
            this.Controls.Add(this.lblPrivHex);
            this.Controls.Add(this.btnSeedToSHA256);
            this.Controls.Add(this.txtSeedToSHA256);
            this.Controls.Add(this.lblSeedToSHA256);
            this.Name = "BTCAddress";
            this.Text = "Bitcoin Address Utility by Casascius (Fixed by hades7946)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeedToSHA256;
        private System.Windows.Forms.TextBox txtSeedToSHA256;
        private System.Windows.Forms.Button btnSeedToSHA256;
        private System.Windows.Forms.Label lblPrivHex;
        private System.Windows.Forms.TextBox txtPrivHex;
        private System.Windows.Forms.Button btnPrivToWIF;
        private System.Windows.Forms.Label lblPrivWIF;
        private System.Windows.Forms.TextBox txtPrivWIF;
        private System.Windows.Forms.Button btnPrivWIFToHex;
        private System.Windows.Forms.Button btnPrivToPub;
        private System.Windows.Forms.Label lblPubHex;
        private System.Windows.Forms.TextBox txtPubHex;
        private System.Windows.Forms.Button btnGenPri;
        private System.Windows.Forms.Button btnPubHexToSha;
        private System.Windows.Forms.Label lblPubSha256;
        private System.Windows.Forms.TextBox txtPubSha256;
        private System.Windows.Forms.Button btnPubShaToRipemd;
        private System.Windows.Forms.Label lblPubRipemd160;
        private System.Windows.Forms.TextBox txtPubRipemd160;
        private System.Windows.Forms.Label lblBtcAddress;
        private System.Windows.Forms.TextBox txtBtcAddress;
        private System.Windows.Forms.Button btnAddToPubRip;
        private System.Windows.Forms.Button btnPubRipToAdd;
        private System.Windows.Forms.ComboBox cboCoinType;
        private System.Windows.Forms.Label lblBtcNetWork;
        private System.Windows.Forms.Button btnBlockExplorer;
        private System.Windows.Forms.Label lblPubKeyPointX;
        private System.Windows.Forms.Label lblPubKeyPointY;
        private System.Windows.Forms.TextBox txtPubKeyPointY;
        private System.Windows.Forms.Label lblBtclNetwork;
        private System.Windows.Forms.TextBox txtBtclNetwork;
        private System.Windows.Forms.TextBox txtPubKeyPointX;
        private System.Windows.Forms.Button btnECDSADec;
        private System.Windows.Forms.Button btnPubToPriv;
        private System.Windows.Forms.Label lblPriKeyDec;
        private System.Windows.Forms.TextBox txtPriKeyDec;
        private System.Windows.Forms.Button btnECDSAHex;
        private System.Windows.Forms.Button btnDecodeTxIdKeys;
        private System.Windows.Forms.Button btnTxID;
    }
}

