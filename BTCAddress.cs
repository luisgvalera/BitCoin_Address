//___________________________________________________________________________________ 
//date: 03apr2008
//function: process BitCoin
//last update: 17Apr2021
//author: luis g. valera
//02 March 1998 - Proyectos Huell@ - Colmena Salud / Send@ - Colmena ARP
//global routines - bitcoin & file management - lgv21feb2008
//update: 08 Febrero 2008 - C++ - VB.NET 2.0 Internal Project
//03abr2012 - Luis Villa - se reestructuran las clases para utilizar metadatos generico -- cualquier db
//08abr2013 - Luis Villa - se integran funciones de otras librerias
//datasource, CalErrorControl, session_management
//___________________________________________________________________________________ 
//Project list luis g. valera
//date: 07mar2008 
//last update: 17Apr2021
//author: Luis Guillermo Valera - Juan Carlos Gonzalez Rodriguez - Hernan Felipe Fonseca Garzon
//04ago2008 - Microsoft Corporation - SHA256
//08sep2010 - BankVision Software Ltda - Occidental de Colombia
//02mar2011 - ADA S.A. - Secretaria Salud Soacha - Aseguramiento en Salud Y Salud Publica
//02ene2012 - Banco Finandina - Otorgamiento y Administracion de Tarjetas de Credito
//05feb2013 - Aciel Colombia SAS - Outsourcing Operativo
//02ene2014 - Aciel Colombia SAS - Outsourcing Operativo
//10feb2015 - Adaptacion para factory version 5.0
//___________________________________________________________________________________ 
using BitCoin_Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoin_Address
{
    public partial class BTCAddress : Form
    {
        public BTCAddress()
        {
            InitializeComponent();
        }
        public string SeedToSHA256 = "";
        public string StrTXID = "";
        public string StrPrivHex = "";
        // function: btnGenPri_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 0. _______________________________________________________________________ 
        private void btnGenPri_Click(object sender, EventArgs e)
        {
            txtPrivHex.Text = EncryptFunctions.RandomPrixHex();
            txtPrivHex.Text = EncryptFunctions.HashToPrivHex(txtSeedToSHA256.Text);
            txtPrivWIF.Text = EncryptFunctions.PrivHexToWIF(txtPrivHex.Text);
            txtPubHex.Text = EncryptFunctions.PrivHexToPubHex(txtPrivHex.Text);
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnSeedToSHA256_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 1. _______________________________________________________________________ 
        private void btnSeedToSHA256_Click(object sender, EventArgs e)
        {
            txtPrivHex.Text = EncryptFunctions.HashToPrivHex(txtSeedToSHA256.Text);
            txtPrivWIF.Text = EncryptFunctions.PrivHexToWIF(txtPrivHex.Text);
            txtPubHex.Text = EncryptFunctions.PrivHexToPubHex(txtPrivHex.Text);
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPrivToWIF_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 2. _______________________________________________________________________ 
        private void btnPrivToWIF_Click(object sender, EventArgs e)
        {
            txtPrivWIF.Text = EncryptFunctions.PrivHexToWIF(txtPrivHex.Text);
            txtPubHex.Text = EncryptFunctions.PrivHexToPubHex(txtPrivHex.Text);
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPrivWIFToHex_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 3. _______________________________________________________________________ 
        private void btnPrivWIFToHex_Click(object sender, EventArgs e)
        {
            txtPrivHex.Text = EncryptFunctions.PrivWIFToHex(txtPrivWIF.Text);
            txtPubHex.Text = EncryptFunctions.PrivHexToPubHex(txtPrivHex.Text);
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPrivToPub_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 4. _______________________________________________________________________ 
        private void btnPrivToPub_Click(object sender, EventArgs e)
        {
            txtPubHex.Text = EncryptFunctions.PrivHexToPubHex(txtPrivHex.Text);
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPubHexToSha_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 7. _______________________________________________________________________ 
        private void btnPubHexToSha_Click(object sender, EventArgs e)
        {
            txtPubSha256.Text = EncryptFunctions.HexHashSha256(txtPubHex.Text);
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPubShaToRipemd_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 8. _______________________________________________________________________ 
        private void btnPubShaToRipemd_Click(object sender, EventArgs e)
        {
            txtPubRipemd160.Text = EncryptFunctions.PubHexToRipemd160Hash(txtPubHex.Text);
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnPubRipToAdd_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 9. _______________________________________________________________________ 
        private void btnPubRipToAdd_Click(object sender, EventArgs e)
        {
            txtBtcAddress.Text = EncryptFunctions.PubHashToAddress(txtPubRipemd160.Text, cboCoinType.Text);
            displayPubHexPoint();
        }

        // function: btnAddToPubRip_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 10. ______________________________________________________________________ 
        private void btnAddToPubRip_Click(object sender, EventArgs e)
        {
            txtPubRipemd160.Text = EncryptFunctions.AddressToPubHash(txtBtcAddress.Text);
            displayPubHexPoint();
        }

        // function: btnPubHexPoint_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 11. ______________________________________________________________________ 
        private void btnPubHexPoint_Click(object sender, EventArgs e)
        {
            displayPubDecPoint();
        }

        // function: btnPubHexPoint_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 12. ______________________________________________________________________ 
        private void btnECDSAHex_Click(object sender, EventArgs e)
        {
            displayPubHexPoint();
        }

        // function: btnAddToPubRip_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 13. ______________________________________________________________________ 
        private void btnBlockExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCoinType.Text == "Testnet")
                {
                    Process.Start("http://www.blockexplorer.com/testnet/address/" + txtBtcAddress.Text);
                }
                else if (cboCoinType.Text == "Namecoin")
                {
                    Process.Start("http://explorer.dot-bit.org/a/" + txtBtcAddress.Text);
                }
                else
                {
                    Process.Start("http://www.blockexplorer.com/address/" + txtBtcAddress.Text);
                }
            }
            catch { }
        }

        // function: btnPubToPriv_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 14. ______________________________________________________________________ 
        private void btnPubToPriv_Click(object sender, EventArgs e)
        {
            txtPrivHex.Text = EncryptFunctions.PubToPriv_Click(txtPubHex.Text);
        }

        // function: btnTxID_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 14. ______________________________________________________________________ 
        //private void btnTxID_Click(object sender, EventArgs e)
        //{
        //    string pubkey = EncryptFunctions.ParceTxId(txtSeedToSHA256.Text).Hex;
        //    int PubHexLength = (pubkey.Length - 2);
        //    if (PubHexLength > 130)
        //    {
        //        pubkey = pubkey.Substring(2, 130);
        //    }
        //    else 
        //    { 
        //        pubkey = ""; 
        //    }
        //    txtPubHex.Text = pubkey;
        //    btnPubHexToSha_Click(null, null);
        //    btnPubShaToRipemd_Click(null, null);
        //}

        // function: btnDecodeTxIdKeys_Click
        // last update: 17Apr2021
        // author: luis g. valera
        // 6. ______________________________________________________________________ 
        private void btnDecodeTxIdKeys_Click(object sender, EventArgs e)
        {
            if (btnDecodeTxIdKeys.Text == "Decode TxID") 
            {
                if (SeedToSHA256.Length == 0)
                {
                    SeedToSHA256 = txtSeedToSHA256.Text;
                    if (StrPrivHex.Length == 0)
                    {
                        StrPrivHex = txtPrivHex.Text;
                    };
                    ClearTextBoxes();
                }
                else if (StrTXID.Length > 0)
                {
                    SeedToSHA256 = txtSeedToSHA256.Text;
                    ClearTextBoxes();
                    txtSeedToSHA256.Text = StrTXID;
                    //btnTxID_Click(null, null);
                };
                // DECODE KEYS
                // phrase hash
                btnDecodeTxIdKeys.Text = "Decode Btc Keys";
                lblSeedToSHA256.Text = "TxID or Hash";
                btnGenPri.Visible = false;
                btnSeedToSHA256.Visible = false;
                btnTxID.Visible = true;
                // ECDSA hash
                lblBtclNetwork.Text = "R Value";
                txtBtclNetwork.Width = 561;
                txtBtclNetwork.Text = "";
                lblBtcNetWork.Visible = false;
                cboCoinType.Visible = false;
                btnBlockExplorer.Visible = false;
                btnECDSAHex.Visible = false;
            }
            else 
            {
                if (StrTXID.Length == 0)
                {
                    StrTXID = txtSeedToSHA256.Text;
                    ClearTextBoxes();
                    if (SeedToSHA256.Length > 0)
                    {
                        txtSeedToSHA256.Text = SeedToSHA256;
                        btnSeedToSHA256_Click(null, null);
                    }
                }
                else if (SeedToSHA256.Length > 0)
                {
                    StrTXID = txtSeedToSHA256.Text;
                    ClearTextBoxes();
                    txtSeedToSHA256.Text = SeedToSHA256;
                    btnSeedToSHA256_Click(null, null);
                }
                else if (StrPrivHex.Length > 0)
                {
                    StrTXID = txtSeedToSHA256.Text;
                    ClearTextBoxes();
                    txtPrivHex.Text = StrPrivHex;
                    btnPrivToWIF_Click(null, null);
                };
                // DECODE TRANSACTION txid
                // phrase hash
                btnDecodeTxIdKeys.Text = "Decode TxID";
                lblSeedToSHA256.Text = "Text to Hash (SHA256)";
                btnGenPri.Visible = true;
                btnSeedToSHA256.Visible = true;
                btnTxID.Visible = false;
                // ECDSA hash
                lblBtclNetwork.Text = "Network (Hex)";
                txtBtclNetwork.Width = 58;
                txtBtclNetwork.Text = "";
                lblBtcNetWork.Visible = true;
                cboCoinType.Visible = true;
                btnBlockExplorer.Visible = true;
                btnECDSAHex.Visible = true;
            }
        }

        // function: txtPrivHex_TextChanged
        // last update: 17Apr2021
        // author: luis g. valera
        // 1. ______________________________________________________________________ 
        private void txtPrivHex_TextChanged(object sender, EventArgs e)
        {
            byte[] StrToByteArray = EncryptFunctions.StringToByteArray(txtPrivHex.Text);
            txtPrivHex.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
        }

        // function: txtPubHex_TextChanged
        // last update: 17Apr2021
        // author: luis g. valera
        // 2. ______________________________________________________________________ 
        private void txtPubHex_TextChanged(object sender, EventArgs e)
        {
            byte[] StrToByteArray = EncryptFunctions.StringToByteArray(txtPubHex.Text);
            txtPubHex.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
        }

        // function: txtPubSha256_TextChanged
        // last update: 17Apr2021
        // author: luis g. valera
        // 3. ______________________________________________________________________ 
        private void txtPubSha256_TextChanged(object sender, EventArgs e)
        {
            byte[] StrToByteArray = EncryptFunctions.StringToByteArray(txtPubSha256.Text);
            txtPubSha256.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
        }

        // function: txtPubRipemd160_TextChanged
        // last update: 17Apr2021
        // author: luis g. valera
        // 4. ______________________________________________________________________ 
        private void txtPubRipemd160_TextChanged(object sender, EventArgs e)
        {   
            byte[] StrToByteArray = EncryptFunctions.StringToByteArray(txtPubRipemd160.Text);
            txtPubRipemd160.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
        }

        // function: displayPubHexPoint
        // last update: 17Apr2021
        // author: luis g. valera
        // 5. ______________________________________________________________________ 
        private void displayPubHexPoint()
        {
            try
            {
                lblPubKeyPointX.Text = "Pub Key [Hex] X:";
                lblPubKeyPointY.Text = "Pub Key [Hex] Y:";
                lblPriKeyDec.Text = "Pri Key (Hex):";

                // NetWork = 2 Characters
                // PubHex = PubKeyPointX + PubKeyPointY
                string source = txtPubHex.Text;
                source = source.Replace(" ", "");
                int PubHexLength = (source.Length - 2) / 2;
                if (PubHexLength < 67)
                {
                    // NetWork
                    txtBtclNetwork.Text = source.Substring(0, 2);
                    source = source.Substring(2, PubHexLength);
                    // PubKeyPointX
                    string PubKeyPointX = "";
                    PubKeyPointX = source.Substring(0, PubHexLength);
                    byte[] StrToByteArray = EncryptFunctions.StringToByteArray(PubKeyPointX);
                    txtPubKeyPointX.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
                    // redim source
                    source = txtPubHex.Text;
                    source = source.Replace(" ", "");
                    source = source.Replace(txtBtclNetwork.Text + PubKeyPointX, "");
                    // PubKeyPointY
                    if (PubHexLength > source.Length)
                    {
                        PubHexLength = source.Length;
                    }
                    string PubKeyPointY = source.Substring(0, PubHexLength);
                    StrToByteArray = EncryptFunctions.StringToByteArray(PubKeyPointY);
                    txtPubKeyPointY.Text = EncryptFunctions.ByteArrayToString(StrToByteArray);
                }
                txtPriKeyDec.Text = txtPrivHex.Text;
            }
            catch { 
            }
        }

        // function: displayPubDecPoint
        // last update: 17Apr2021
        // author: luis g. valera
        // 6. ______________________________________________________________________ 
        private void displayPubDecPoint()
        {
            try
            {
                lblPubKeyPointX.Text = "Pub Key [Dec] X:";
                lblPubKeyPointY.Text = "Pub Key [Dec] Y:";
                lblPriKeyDec.Text = "Pri Key (Dec):";

                // NetWork = 2 Characters
                // PubHex = PubKeyPointX + PubKeyPointY
                string source = txtPubHex.Text;
                source = source.Replace(" ", "");
                int PubHexLength = (source.Length - 2) / 2;
                if (PubHexLength < 67)
                {
                    // NetWork
                    txtBtclNetwork.Text = source.Substring(0, 2);
                    source = source.Substring(2, PubHexLength);
                    // PubKeyPointX
                    string PubKeyPointX = "";
                    PubKeyPointX = source.Substring(0, PubHexLength);
                    //byte[] StrToByteArray = EncryptFunctions.StringToByteArray(PubKeyPointX);
                    //txtPubKeyPointX.Text = EncryptFunctions.HexToDec(StrToByteArray);
                    txtPubKeyPointX.Text = EncryptFunctions.HexToDec(PubKeyPointX);
                    // redim source
                    source = txtPubHex.Text;
                    source = source.Replace(" ", "");
                    source = source.Replace(txtBtclNetwork.Text + PubKeyPointX, "");
                    // PubKeyPointY
                    if (PubHexLength > source.Length)
                    {
                        PubHexLength = source.Length;
                    }
                    string PubKeyPointY = source.Substring(0, PubHexLength);
                    //StrToByteArray = EncryptFunctions.StringToByteArray(PubKeyPointY);
                    //txtPubKeyPointY.Text = EncryptFunctions.HexToDec(StrToByteArray);
                    txtPubKeyPointY.Text = EncryptFunctions.HexToDec(PubKeyPointY);
                }
                txtPriKeyDec.Text = EncryptFunctions.HexToDec(txtPrivHex.Text);
            }
            catch
            {
            }
        }
        // function: ClearTextBoxes
        // last update: 17Apr2021
        // author: luis g. valera
        // 6. ______________________________________________________________________ 
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
