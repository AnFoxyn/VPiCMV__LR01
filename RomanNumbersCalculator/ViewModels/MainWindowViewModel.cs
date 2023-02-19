using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using RomanNumbersCalculator.Models;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string _secondNum;
        string _operation = " ";
        private RomanNumberExtend _result;
        private RomanNumberExtend _secondValue;

        public MainWindowViewModel()
        {
            AddNum = ReactiveCommand.Create<string, string>(AddNumTo);
            ExecuteOperationCommand = ReactiveCommand.Create<string>(ExecuteOperation);
        }

        public string ShowValue
        {
            set { this.RaiseAndSetIfChanged(ref _secondNum, value); }
            get { return _secondNum; }
        }

        public ReactiveCommand<string, string> AddNum { get; }
        public ReactiveCommand<string, Unit> ExecuteOperationCommand { get; }

        private string AddNumTo(string str)
        {
            if (_operation == "n")
            {
                ShowValue = str;
                _operation = " ";
            }
            else
                ShowValue += str;
            return ShowValue;
        }

        private void ExecuteOperation(string operation)
        {
            if (RomanNumberExtend.ToInt(_secondNum) > 0)
                _secondValue = new RomanNumberExtend(_secondNum);
            RomanNumber tmp;
            try
            {
                switch (_operation[0])
                {
                    case '+':
                        tmp = _result + _secondValue;
                        _result = new RomanNumberExtend(tmp.ToString());
                        break;

                    case '*':
                        tmp = _result * _secondValue;
                        _result = new RomanNumberExtend(tmp.ToString());
                        break;

                    case '/':
                        tmp = _result / _secondValue;
                        _result = new RomanNumberExtend(tmp.ToString());
                        break;

                    case '-':
                        tmp = _result - _secondValue;
                        _result = new RomanNumberExtend(tmp.ToString());
                        break;

                    case ' ':
                        if (RomanNumberExtend.ToInt(_secondNum) > 0)
                            _result = new RomanNumberExtend(_secondNum);
                        break;

                    case 'R':
                        if (RomanNumberExtend.ToInt(_secondNum) > 0)
                            _result = new RomanNumberExtend(_secondNum);
                        break;

                    default:
                        break;
                }

                if (operation == "=")
                {
                    if (_result != null)
                        ShowValue = _result.ToString();
                    _operation = "R";
                    _result = null;
                }
                else
                {
                    _operation = operation;
                    ShowValue = "";
                }
            }
            catch (RomanNumberException ex) { ShowValue = $"Ошибка: {ex.Message}"; }
        }
    }
}
