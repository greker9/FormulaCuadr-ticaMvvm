namespace Formula_Cuadrativa_MVVM
    {
        public partial class MainPage : ContentPage
        {




            private Entry value1Entry;
            private Entry value2Entry;
            private Label resultLabel;

            public MainPage()
            {
                // Crear elementos de la interfaz de usuario
                value1Entry = new Entry { Placeholder = "Ingrese Valor 1" };
                value2Entry = new Entry { Placeholder = "Ingrese Valor 2" };
                Button calculateButton = new Button { Text = "Calcular" };
                Button clearButton = new Button { Text = "Limpiar" };
                resultLabel = new Label();

                // Asignar manejadores de eventos para los botones
                calculateButton.Clicked += CalculateButton_Clicked;
                clearButton.Clicked += ClearButton_Clicked;

                // Crear un diseño de pila para organizar los elementos de la interfaz de usuario
                StackLayout stackLayout = new StackLayout
                {
                    Padding = new Thickness(20),
                    Children = { value1Entry, value2Entry, calculateButton, clearButton, resultLabel }
                };

                // Establecer el contenido de la página
                Content = stackLayout;
            }



            private void CalculateButton_Clicked(object sender, EventArgs e)
            {
                // Validar campos de entrada
                if (string.IsNullOrWhiteSpace(value1Entry.Text) || string.IsNullOrWhiteSpace(value2Entry.Text))
                {
                    resultLabel.Text = "Por favor, ingrese ambos valores.";
                    return;
                }

                // Convertir los valores de entrada a números
                if (!double.TryParse(value1Entry.Text, out double value1) || !double.TryParse(value2Entry.Text, out double value2))
                {
                    resultLabel.Text = "Entrada inválida. Por favor, ingrese valores numéricos válidos.";
                    return;
                }

                // Realizar la operación (por ejemplo, suma)
                double result = value1 + value2;

                // Mostrar el resultado
                resultLabel.Text = $"Resultado: {result}";
            }

            private void ClearButton_Clicked(object sender, EventArgs e)
            {
                // Limpiar los campos de entrada y el resultado
                value1Entry.Text = string.Empty;
                value2Entry.Text = string.Empty;
                resultLabel.Text = string.Empty;
            }
        }
    }






