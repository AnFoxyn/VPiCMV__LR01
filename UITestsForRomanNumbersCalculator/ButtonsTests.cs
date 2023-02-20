using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class ButtonsTests
    {
        [Fact]
        public async void checkAdd__1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name== "I");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("CI"), "~ERROR~: C + I != CI");
        }

        [Fact]
        public async void checkAdd__2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("XXV"), "~ERROR~: V + V + V + X != XXV");
        }

        [Fact]
        public async void checkAdd__3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var addButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            addButton.Command.Execute(addButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("MC"), "~ERROR~: D + L + L + D != MC");
        }

        [Fact]
        public async void checkSub__1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var subButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            subButton.Command.Execute(subButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("XCIX"), "~ERROR~: C - I != XCIX");
        }

        [Fact]
        public async void checkSub__2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var subButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var thirdButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            subButton.Command.Execute(subButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            subButton.Command.Execute(subButton.CommandParameter);
            for (int i = 1; i <= 4; i++)
                thirdButton.Command.Execute(thirdButton.CommandParameter);

            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("X"), "~ERROR~: C - L - XXXX != X");
        }

        [Fact]
        public async void checkSub__3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var subButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            subButton.Command.Execute(subButton.CommandParameter);

            for (int i = 0; i < 4; i++) 
                secondButton.Command.Execute(secondButton.CommandParameter); 

            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("XXX"), "~ERROR~: L - VVVV != XXX");
        }

        [Fact]
        public async void checkMul__1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var mulButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            mulButton.Command.Execute(mulButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("C"), checkAnswer);
        }

        [Fact]
        public async void checkMul__2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var mulButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            mulButton.Command.Execute(mulButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            mulButton.Command.Execute(mulButton.CommandParameter);
            firstButton.Command.Execute(firstButton.CommandParameter);
            mulButton.Command.Execute(mulButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("MMMMMMCCL"), "~ERROR~: V * V * V * L != MMMMMMCCL");
        }

        [Fact]
        public async void checkDiv__1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var divButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            firstButton.Command.Execute(firstButton.CommandParameter);
            divButton.Command.Execute(divButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("XX"), "~ERROR~: M / L != XX");
        }

        [Fact]
        public async void checkDiv__2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var resultButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var resetButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var divButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var firstButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var secondButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var thirdButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var fourthButton = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

           
            firstButton.Command.Execute(firstButton.CommandParameter);
            secondButton.Command.Execute(secondButton.CommandParameter);
            thirdButton.Command.Execute(thirdButton.CommandParameter);
            thirdButton.Command.Execute(thirdButton.CommandParameter);
            fourthButton.Command.Execute(fourthButton.CommandParameter);

            for (var i = 0; i < 4; i++)
            {
                divButton.Command.Execute(divButton.CommandParameter);
                fourthButton.Command.Execute(fourthButton.CommandParameter);
            }

            resultButton.Command.Execute(resultButton.CommandParameter);

            await Task.Delay(50);

            string checkAnswer = (textBox.Text);
            resetButton.Command.Execute(resetButton.CommandParameter);

            Assert.True(checkAnswer.Equals("I"), checkAnswer);
        }
    }
}