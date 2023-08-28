namespace Heron_5022358.Views;

public partial class TrianguloEquilateroPage : ContentPage
{
	public TrianguloEquilateroPage()
	{
		InitializeComponent();
	}

    private void calculo_Clicked(object sender, EventArgs e)
    {
        
       if(!string.IsNullOrEmpty(A.Text) && !string.IsNullOrEmpty(B.Text) && !string.IsNullOrEmpty(C.Text))
        {
            double dato1,dato2,dato3;
            dato1= double.Parse(A.Text);
            dato2= double.Parse(B.Text);
            dato3= double.Parse(C.Text);
            double s = (dato1 + dato2 + dato3) / 2;
            double area = Math.Sqrt(s * (s - dato1) * (s - dato2) * (s - dato3));
            Respu.Text = Convert.ToString(s);
            resp.Text = Convert.ToString(area);
        }
       else
        {
            DisplayAlert("Error", "Introduce todo los numeros", "Ok");
        }
    }
}