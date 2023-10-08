using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public class CalculatorModel
    {
        // the current numbers 
        public string _currentNumber
        {
            get;
            set;
        }

        // the numbers to be calculated
        public string _cacheResultNumber
        {
            get;
            set;
        }

        // the numbers to be calculated
        public string _cacheLastInputNumber
        {
            get;
            set;
        }

        // whether the number is a decimal
        public bool _isUsePoint
        {
            get;
            set;
        }

        // the operation to be performed
        public string _operation
        {
            get;
            set;
        }

        // the last operation to be performed
        public string _lastOperation
        {
            get;
            set;
        }

        // constructor
        public CalculatorModel()
        {
            _currentNumber = "";
            _cacheResultNumber = "";
            _cacheLastInputNumber = "";
        }

        // insert the number to the last of the cache number
        public string InsertStringToCurrentNumberLast(string number)
        {
            const string DOT = "";
            if (number.Equals(DOT))
            {
                if (_isUsePoint)
                {
                    return _currentNumber;
                }
                _isUsePoint = true;
            }
            _currentNumber = _currentNumber + number;
            return _currentNumber;
        }

        // use calculation operation
        public string UseCalculationOperation(string operation)
        {
            _operation = operation;
            _lastOperation = operation;
            if (_cacheResultNumber.Equals(""))
            {
                _cacheResultNumber = _currentNumber;
            }
            else if (_currentNumber.Equals(""))
            {
                return _cacheResultNumber;
            }
            else
            {
                _cacheResultNumber = Calculate();
            }
            _currentNumber = "";
            _isUsePoint = false;
            return _cacheResultNumber;
        }

        // use equal operation
        public string UseEqualOperation()
        {
            if (_cacheResultNumber.Equals(""))
            {
                _cacheResultNumber = _currentNumber;
            }
            else
            {
                _cacheResultNumber = HandleCalculate();
            }
            _currentNumber = "";
            _isUsePoint = false;
            return _cacheResultNumber;
        }

        // handle is need to calculate
        public string HandleCalculate()
        {
            if (!_currentNumber.Equals(""))
            {
                _cacheLastInputNumber = _currentNumber;
            }
            else if (!_cacheLastInputNumber.Equals(""))
            {
                _currentNumber = _cacheLastInputNumber;
            }
            else
            {
                return _cacheResultNumber;
            }
            _operation = _lastOperation;
            return Calculate();
        }

        // handle plus 
        public string HandlePlus(string handleResult)
        {
            const string PLUS = "+";
            if (_operation == PLUS)
            {
                return (Convert.ToDouble(_cacheResultNumber) + Convert.ToDouble(_currentNumber)).ToString();
            }
            return handleResult;
        }

        // handle minus
        public string HandleMinus(string handleResult)
        {
            const string MINUS = "-";
            if (_operation == MINUS)
            {
                return (Convert.ToDouble(_cacheResultNumber) - Convert.ToDouble(_currentNumber)).ToString();
            }
            return handleResult;
        }

        // handle multiply
        public string HandleMultiply(string handleResult)
        {
            const string MULTIPLY = "*";
            if (_operation == MULTIPLY)
            {
                return (Convert.ToDouble(_cacheResultNumber) * Convert.ToDouble(_currentNumber)).ToString();
            }
            return handleResult;
        }

        // handle divide
        public string HandleDivide(string handleResult)
        {
            const string DIVIDE = "/";
            if (_operation == DIVIDE)
            {
                return (Convert.ToDouble(_cacheResultNumber) / Convert.ToDouble(_currentNumber)).ToString();
            }
            return handleResult;
        }

        // calculate the result
        public string Calculate()
        {
            string result = "";

            if (_operation == null)
            {
                return _currentNumber;
            }

            result = HandlePlus(result);
            result = HandleMinus(result);
            result = HandleMultiply(result);
            result = HandleDivide(result);

            _cacheResultNumber = result;
            _currentNumber = "";
            _operation = null;
            _isUsePoint = false;
            return result;
        }

        // clear the result
        public string Clear()
        {
            _currentNumber = "";
            _cacheResultNumber = "";
            _cacheLastInputNumber = "";
            _operation = null;
            _isUsePoint = false;
            return "";
        }

        //clear the entry
        public string ClearEntry()
        {
            _currentNumber = "";
            _cacheLastInputNumber = "";
            _isUsePoint = false;
            return "";
        }

    }
}
