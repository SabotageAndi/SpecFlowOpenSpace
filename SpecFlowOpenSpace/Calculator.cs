using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowOpenSpace
{
    public class Calculator
    {
        enum NextAction
        {
            Add,
            Sub,
            Multi,
            Div,
        }

        private decimal _currentValue;
        private NextAction? _nextAction;

        public decimal CurrentValue
        {
            get { return _currentValue; }
        }

        public void EnterNumber(decimal number)
        {
            if (_nextAction == null)
            {
                _currentValue = number;
                return;
            }

            switch (_nextAction.Value)
            {
                case NextAction.Add:
                    _currentValue += number;
                    break;
                case NextAction.Sub:
                    _currentValue -= number;
                    break;
                case NextAction.Multi:
                    _currentValue *= number;
                    break;
                case NextAction.Div:
                    _currentValue /= number;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Add()
        {
            _nextAction = NextAction.Add;
        }

        public void Sub()
        {
            _nextAction = NextAction.Sub;
        }

        public void Multi()
        {
            _nextAction = NextAction.Multi;
        }

        public void Div()
        {
            _nextAction = NextAction.Div;
        }

        public void Reset()
        {
            _nextAction = null;
            _currentValue = 0;
        }
    }
}
