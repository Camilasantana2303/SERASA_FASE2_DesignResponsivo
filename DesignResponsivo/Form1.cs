namespace DesignResponsivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void renderizaInterface()
        {
            int menuEsquerdo_largura = 200;
            int menuEsquerdo_altura=ClientSize.Height;
            int painel_largura= menuEsquerdo_altura+menuEsquerdo_largura;
            WindowState = FormWindowState.Maximized;//Deixa com a tela maior

            //WIDTH -> LARGURA
            //HEIGH -> ALTURA

            // Jogar o painel no meio da tela

            painel.Location= new Point (ClientSize.Width/2 - painel.Size.Width/2+150, ClientSize.Height/2- painel.Size.Height / 2);

            // Configuração do menu esquerdo
            menuEsquerdo.Location = new Point(0, 0);
            menuEsquerdo.Size = new Size(400,ClientSize.Height);


            //Menu horizontal
            menuHorizontal.Location=new Point(0, 0);
            menuHorizontal.Size = new Size(300,ClientSize.Height);
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void menuEsquerdo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}