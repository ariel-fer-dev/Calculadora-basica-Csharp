using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        public bool nuevoCalculo = true, esCero = false, negativo = false;
        public double n1 = 0, n2 = 0;
        private string operacion = "";
        private int tieneComa;


        public Form1() {
            InitializeComponent();

        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e) {
            int code = e.KeyChar;

            //Console.WriteLine("Tecla = " + code);

            switch (code) {
                case 08:
                    bBack.PerformClick();
                    break;
                case 127:
                    bClear.PerformClick();
                    break;

                case 13:
                    bResultado.PerformClick();
                    break;
            }

            if (txtFieldPantalla.Text.Length < 19) {

                switch (code) {
                    case 48:
                        b0.PerformClick();
                        break;

                    case 49:
                        b1.PerformClick();
                        break;

                    case 50:
                        b2.PerformClick();
                        break;

                    case 51:
                        b3.PerformClick();
                        break;

                    case 52:
                        b4.PerformClick();
                        break;

                    case 53:
                        b5.PerformClick();
                        break;

                    case 54:
                        b6.PerformClick();
                        break;

                    case 55:
                        b7.PerformClick();
                        break;

                    case 56:
                        b8.PerformClick();
                        break;

                    case 57:
                        b9.PerformClick();
                        break;

                    case 44:
                        bComa.PerformClick();
                        break;

                    case 46:
                        bComa.PerformClick();
                        break;

                    case 45:
                        bResta.PerformClick();
                        break;

                    case 43:
                        bSuma.PerformClick();
                        break;

                    case 42:
                        bProducto.PerformClick();
                        break;

                    case 47:
                        bDivision.PerformClick();
                        break;

                }
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");

            }
            this.txtFieldPantalla.Focus();
            this.txtFieldPantalla.DeselectAll();
        }

        private void b1_Click(object sender, EventArgs e) {

            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');
                //Console.WriteLine(tieneComa);
                //Console.WriteLine("lbPantalla = " + lbPantalla.Text);
                //Console.WriteLine(Convert.ToDouble((lbPantalla.Text.Replace(".", "")) + "1").ToString("#,###.##########"));

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "1"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "1").ToString("#,###.##########")));

            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
            panel.Select();
        }

        private void bClear_Click(object sender, EventArgs e) {

            lbPantalla.Text = "";
            txtFieldPantalla.Text = "";
            nuevoCalculo = true;
            operacion = "";
            n1 = 0;
            n2 = 0;
            this.txtFieldPantalla.Focus();
            //this.txtFieldPantalla.DeselectAll();
        }

        private void b2_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "2"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "2").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b3_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "3"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "3").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b4_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "4"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "4").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b5_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "5"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "5").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b6_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "6"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "6").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b7_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "7"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "7").ToString("#,###.##########")));
            } else {
                MessageBox.Show("   Cantidad maxima de caracteres superada   " + "\n", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b8_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "8"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "8").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void b9_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = "";
                nuevoCalculo = false;
            }
            if (lbPantalla.Text.Length < 20) {
                tieneComa = lbPantalla.Text.IndexOf(',');

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "9"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "9").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");

            }
            this.txtFieldPantalla.Focus();
        }

        private void b0_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = null;
                nuevoCalculo = false;
            }

            if (lbPantalla.Text.Length < 20) {
                if (lbPantalla.Text.Equals("")) {
                    lbPantalla.Text = "0";
                }
                tieneComa = lbPantalla.Text.IndexOf(',');

                //    Console.WriteLine("Cero = " + Convert.ToDouble("0").ToString("#,###.##########") + "0");

                lbPantalla.Text = ((tieneComa != -1) ? lbPantalla.Text + "0"
                        : (Convert.ToDouble(lbPantalla.Text.Replace(".", "") + "0").ToString("#,###.##########")));
            } else {
                MessageBox.Show("Cantidad maxima de caracteres superada", "Aviso");
            }
            this.txtFieldPantalla.Focus();
        }

        private void bComa_Click(object sender, EventArgs e) {
            if (nuevoCalculo) {
                lbPantalla.Text = null;
                nuevoCalculo = false;
            }

            tieneComa = lbPantalla.Text.IndexOf(',');

            //Console.WriteLine("TieneComa = " + tieneComa);

            if (!lbPantalla.Text.Contains(',')) {
                lbPantalla.Text = ("".Equals(lbPantalla.Text)) ?
                  "0," : lbPantalla.Text + ",";
            }

            this.txtFieldPantalla.Focus();
            this.txtFieldPantalla.DeselectAll();
        }

        private void bBack_Click(object sender, EventArgs e) {

            if (!"".Equals(lbPantalla.Text) && nuevoCalculo == false) {
                int largo = lbPantalla.Text.Length;

                if (largo > 1) {
                    lbPantalla.Text = lbPantalla.Text.Substring(0, largo - 1);
                    lbPantalla.Text = Convert.ToDouble(lbPantalla.Text.Substring(0, largo - 1)).ToString("#,###.##########");
                } else {
                    lbPantalla.Text = "";
                }
            }

            this.txtFieldPantalla.Focus();
        }

        private void txtFieldPantalla_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                lbPantalla.Text = "";
                txtFieldPantalla.Text = "";
                n1 = 0;
                n2 = 0;
                operacion = "";
                nuevoCalculo = true;
                panel.Text = panel.Text + "-----------------------------------" + Environment.NewLine;

            }
        }

        private void Form1_Activated(object sender, EventArgs e) {
            this.txtFieldPantalla.Focus();
        }

        private void bSigno_Click(object sender, EventArgs e) {

            if (!lbPantalla.Text.Equals("")) {
                if (lbPantalla.Text.Contains("-")) {
                    lbPantalla.Text = lbPantalla.Text.Replace("-", "");
                } else {
                    lbPantalla.Text = "-" + lbPantalla.Text.Replace("-", "");
                }
            }
            this.txtFieldPantalla.Focus();
        }

        private void bSuma_Click(object sender, EventArgs e) {

            if (!lbPantalla.Text.Equals("")) {

                if (n1 != 0 && "suma".Equals(operacion)) {

                    panel.Text = panel.Text + (char)43 + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                    //         Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########")
                    n1 = n1 + Convert.ToDouble(lbPantalla.Text.Replace(".", ""));

                    //Console.WriteLine("Operacion suma");

                } else {
                    switch (operacion) {
                        case "producto":
                            n1 = n1 * Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)42) + "  " + Convert.ToDouble(lbPantalla.Text).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "resta":
                            n1 = n1 - Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)45) + "  " + Convert.ToDouble(lbPantalla.Text).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "division":
                            n1 = n1 / Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)47) + "  " + Convert.ToDouble(lbPantalla.Text).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        default:
                            panel.Text = panel.Text + "    " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            n1 = Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            break;
                    }
                }
            }
            //Console.WriteLine("N1 en suma: " + n1);
            operacion = "suma";
            lbPantalla.Text = "";

            this.txtFieldPantalla.Focus();
            //  this.txtFieldPantalla.DeselectAll();
            panel.Select(panel.Text.Length, 0);
        }

        private void bResultado_Click(object sender, EventArgs e) {

            if (!"".Equals(lbPantalla.Text)) {

                n2 = Convert.ToDouble(lbPantalla.Text.Replace(".", ""));

                //Console.WriteLine("n2: " + n2);

                if (null != operacion) {
                    switch (operacion) {

                        case "suma": {
                                double resultado = n1 + n2;
                                lbPantalla.Text = resultado.ToString("#,0.##########");

                                panel.Text = panel.Text + (char)43 + "  " + Convert.ToDouble(n2).ToString("#,0.##########") + Environment.NewLine;
                                panel.Text = panel.Text + "========================" + Environment.NewLine;
                                panel.Text = panel.Text + (char)61 + "  " + Convert.ToDouble(resultado).ToString("#,0.##########") + Environment.NewLine + Environment.NewLine;

                                operacion = "";
                                nuevoCalculo = true;
                                n1 = 0;
                                n2 = (resultado);
                                break;
                            }

                        case "resta": {
                                double resultado = n1 - n2;
                                lbPantalla.Text = resultado.ToString("#,0.##########");

                                panel.Text = panel.Text + (char)45 + "  " + n2.ToString("#,0.##########") + Environment.NewLine;
                                panel.Text = panel.Text + "========================" + Environment.NewLine;
                                panel.Text = panel.Text + (char)61 + "  " + resultado.ToString("#,0.##########") + Environment.NewLine + Environment.NewLine;

                                operacion = "";
                                nuevoCalculo = true;
                                n1 = 0;
                                n2 = (resultado);
                                break;
                            }

                        case "division": {
                                if (n2 == 0) {
                                    MessageBox.Show("  No se puede dividir por cero  ");
                                    lbPantalla.Text = "";

                                    operacion = "";
                                    nuevoCalculo = true;
                                    n1 = 0;
                                    n2 = 0;

                                } else {
                                    double resultado = n1 / n2;
                                    lbPantalla.Text = resultado.ToString("#,0.##########");

                                    panel.Text = panel.Text + (char)47 + "  " + n2.ToString("#,0.##########") + Environment.NewLine;
                                    panel.Text = panel.Text + "========================" + Environment.NewLine;
                                    panel.Text = panel.Text + (char)61 + "  " + resultado.ToString("#,0.##########") + Environment.NewLine + Environment.NewLine;

                                    operacion = "";
                                    nuevoCalculo = true;
                                    n1 = 0;
                                    n2 = (resultado);
                                }
                                break;

                            }
                        case "producto": {
                                double resultado = n1 * n2;
                                lbPantalla.Text = resultado.ToString("#,0.##########");

                                panel.Text = panel.Text + (char)42 + "  " + n2.ToString("#,0.##########") + Environment.NewLine;
                                panel.Text = panel.Text + "========================" + Environment.NewLine;
                                panel.Text = panel.Text + (char)61 + "  " + resultado.ToString("#,0.##########") + Environment.NewLine + Environment.NewLine;

                                n1 = 0;
                                n2 = 0;
                                operacion = "";
                                nuevoCalculo = true;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            esCero = false;

            this.txtFieldPantalla.Focus();
            this.txtFieldPantalla.DeselectAll();
            panel.Select(panel.Text.Length - (lbPantalla.Text.Length + 4), lbPantalla.Text.Length + 3);
            Console.WriteLine(lbPantalla.Text.Length);
        }

        private void bResta_Click(object sender, EventArgs e) {

            if (!lbPantalla.Text.Equals("")) {

                if (n1 != 0 && "resta".Equals(operacion)) {

                    n1 = n1 - Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                    panel.Text = panel.Text + ((char)45) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;

                } else {
                    switch (operacion) {
                        case "producto":
                            n1 = n1 * Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)42) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "suma":
                            n1 = n1 + Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)43) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "division":
                            n1 = n1 / Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)47) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        default:
                            panel.Text = panel.Text + "   " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            n1 = Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            break;
                    }
                }
            }
            //Console.WriteLine("N1 en resta: " + n1);
            operacion = "resta";
            lbPantalla.Text = "";
            //}
            this.txtFieldPantalla.Focus();
            this.txtFieldPantalla.DeselectAll();
            panel.Select(panel.Text.Length, 0);
        }

        private void bDivision_Click(object sender, EventArgs e) {
            if (!lbPantalla.Text.Equals("")) {

                if (n1 != 0 && "division".Equals(operacion)) {

                    n1 = n1 / Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                    panel.Text = panel.Text + ((char)47) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                } else {
                    switch (operacion) {
                        case "producto":
                            n1 = n1 * Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)42) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "suma":
                            n1 = n1 + Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)43) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "resta":
                            n1 = n1 - Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)45) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        default:
                            panel.Text = panel.Text + "   " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            n1 = Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            //panel.Text = panel.Text + "   " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,###.##########") + Environment.NewLine;
                            break;
                    }
                }
            }
            Console.WriteLine("N1: " + n1);
            operacion = "division";
            lbPantalla.Text = "";

            this.txtFieldPantalla.Focus();
            panel.Select(panel.Text.Length, 0);
        }

        private void panel_TabIndexChanged(object sender, EventArgs e) {
            this.txtFieldPantalla.Focus();

        }

        private void panel_Click(object sender, EventArgs e) {
            this.txtFieldPantalla.Focus();
            //  this.lbPantalla.Focus();
        }

        private void panel_Click_1(object sender, EventArgs e) {
            this.txtFieldPantalla.Focus();
            this.lbPantalla.Focus();
        }

        private void panel_MouseClick(object sender, MouseEventArgs e) {
            this.txtFieldPantalla.Focus();
        }

        private void bProducto_Click(object sender, EventArgs e) {
            if (!lbPantalla.Text.Equals("")) {

                if (n1 != 0 && "producto".Equals(operacion)) {

                    //jTextPane1.setText(jTextPane1.getText() + fm.format(Double.parseDouble(txtPantalla.getText().replace(".", "").replace(",", "."))) + "  " + ((char) 43) + "\n");

                    n1 = n1 * Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                    panel.Text = panel.Text + ((char)42) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                } else {
                    switch (operacion) {
                        case "resta":
                            n1 = n1 - Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)45) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "suma":
                            n1 = n1 + Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)43) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        case "division":
                            n1 = n1 / Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            panel.Text = panel.Text + ((char)47) + "  " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            break;

                        default:
                            panel.Text = panel.Text + "   " + Convert.ToDouble(lbPantalla.Text.Replace(".", "")).ToString("#,0.##########") + Environment.NewLine;
                            n1 = Convert.ToDouble(lbPantalla.Text.Replace(".", ""));
                            break;
                    }
                }
            }
            //Console.WriteLine("N1: " + n1);
            operacion = "producto";
            lbPantalla.Text = "";

            this.txtFieldPantalla.Focus();
            panel.Select(panel.Text.Length, 0);
        }

        private void bLimpiarPanel_Click(object sender, EventArgs e) {
            panel.Text = "";

            this.txtFieldPantalla.Focus();
            this.txtFieldPantalla.DeselectAll();
            //panel.Select(panel.Text.Length, 0);
            //panel.ScrollToCaret();

        }

        private void panel_TextChanged(object sender, EventArgs e) {
            panel.SelectionStart = panel.Text.Length;
            panel.ScrollToCaret();
            panel.Select(panel.Text.Length - 10, 10);
        }
    }
}

