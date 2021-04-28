﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Animations;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Projet_Onssa
{
    class DeclarationGlobale
    {
        public static void vider(Control f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
                else
                {
                    if (c is MaterialTextBox)
                    {
                        MaterialTextBox t = (MaterialTextBox)c;
                        t.Text = "";
                    }
                    else
                    {
                        if (c is MaterialTextBox)
                        {
                            MaterialTextBox t = (MaterialTextBox)c;
                            t.Clear();
                        }

                    }
                }
                if (c.Controls.Count != 0)
                {
                    vider(c);
                }
            }

        }


        public static void load(DataGridView dv, List<object> b )
        {
           
        }

        
       


    }
}
