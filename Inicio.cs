namespace FotoRoman;


public partial class Inicio : Form
{
    public Inicio()
    {
        InitializeComponent();
    }

    private void abrirFormulario(object sender, EventArgs e)
    {

    }


    private void menuusuario_Click(object sender, EventArgs e)
    {
    
    }

    private void iconMenuItem21_Click(object sender, EventArgs e)
    {
        // Crea una instanccia del formulario FrmUsuario
        FrmUsuario frmUsuario = new FrmUsuario();

        // Mostrarlo
        frmUsuario.Show(); // Usa ShowDialog() si quieres que sea modal
    }
}

