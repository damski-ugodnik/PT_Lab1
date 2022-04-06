using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Calc;
namespace PT_Lab1
{
    public partial class Form1 : Form
    {
        #region stateVars
        private double addendum1, addendum2;
        private int AfterCommaDigits = 0;
        private int Max=500000, Min=-300000;
        private bool AfterCommaMark = false;
        private char[] actions = { '+', '-', '*', '/' };
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MinValueBox.Text = Min.ToString();
            MaxValueBox.Text = Max.ToString();
        }
      
        #region textEdition
        /// <summary>
        /// Обработчик события изменения текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Field_TextChanged(object sender, EventArgs e)
        {
            Field.SelectionStart = Field.TextLength;
            errorProvider.Clear();
            string s = Field.Text;
            // определение значений операндов
            if (s.Length > 0)
            {
                if (s.IndexOf('-', 0, s.Length) > 0 || s.IndexOf('-', 1, s.Length - 1) > 0 || s.IndexOf('+', 0, s.Length) != -1 || s.IndexOf('*', 0, s.Length) != -1 || s.IndexOf('/', 0, s.Length) != -1)
                {

                    double.TryParse(s.Substring(s.LastIndexOfAny(actions) + 1), out addendum2);
                    if (s[s.LastIndexOfAny(actions)] == '-')
                    {
                        addendum2 *= -1;
                    }
                }

                double.TryParse(s, out addendum1);

                if (s.Contains("sqrt(") && (s.IndexOf(')') - (s.IndexOf('(') + 1))>0)
                {
                    double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)), out addendum1);
                }
                if (s.Contains("sin(") && (s.IndexOf(')') - (s.IndexOf('(') + 1)) > 0)
                {
                    double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)), out addendum1);
                }
            }
            // проверка количества цифр после запятой
            if (Field.Text.Contains(','))
            {
                int i = Field.Text.LastIndexOf(',');// расположение последней запятой в строке
                int c = Field.Text.IndexOfAny(actions, i) - 1;// расположение оператора
                if (c < i)// если идёт работа со вторым операндом, то расположение оператора будет перед запятой, или оператор ещё не введён, тогда с = последнему индексу в строке
                {
                    c = Field.Text.Length - 1;
                }
                if (Field.Text.Contains(')'))// если строка содержит закрытую скобку, тогда с будет равно индексу перед скобкой
                {
                    c = Field.Text.IndexOf(')', i) - 1;
                }

                AfterCommaDigits = c - i;// вычисление количества цифр после запятой

                if (Field.Text.IndexOfAny(actions) == Field.Text.Length - 1)// Если последний символ в строке это оператор, тогда число знаков посое запятой обнуляется и снимается метка ввода после запятой
                {
                    AfterCommaDigits = 0; AfterCommaMark = false;

                }
            }
            label3.Text = AfterCommaMark.ToString();
            label5.Text = AfterCommaDigits.ToString();
        }

        #region insertion
        /// <summary>
        /// Метод добавления текста в поле редактирования с помощью кнопок в форме
        /// </summary>
        /// <param name="symbol"></param>
        private void AddText(char symbol)
        { 
            addendum1 = (Min + Max) / 2; addendum2 = (Min + Max) / 2;// определение значений операндов по умолчанию
            // Если символ число, оператор или запятая, то происходит проверка следующих условий
            if (Char.IsDigit(symbol) || symbol == '-' || symbol == '+' || symbol == '/' || symbol == '*'||symbol== (char)Keys.Back||symbol==',')
            {
                string s = Field.Text;
                // Если в строке есть знак равенства, значит уже были произведены вычисления и первым операндом будет результат предыдущей операции (возможно дальнейшее редактирование полученного результата)
                if (s.Contains('='))
                {
                    Field.Text = s.Substring(s.IndexOf('=') + 2);
                }
                // определение значений введённых операндов
                if (s.Length > 0)
                {

                    if (s.IndexOf('-', 0, s.Length) > 0 || s.IndexOf('-', 1, s.Length - 1) > 0 || s.IndexOf('+', 0, s.Length) != -1 || s.IndexOf('*', 0, s.Length) != -1 || s.IndexOf('/', 0, s.Length) != -1)
                    {
                        double.TryParse(s.Substring(s.LastIndexOfAny(actions) + 1) + symbol, out addendum2);
                    }
                    else
                    {
                        double.TryParse(s + symbol, out addendum1);
                    }
                    if (s.Contains("sqrt("))
                    {
                        double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)) + symbol, out addendum1);
                    }
                    if (s.Contains("sin("))
                    {
                        double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)) + symbol, out addendum1);
                    }
                }
                
                if (Char.IsDigit(symbol)||symbol==',')// Если символ - число или запятая
                {
                    
                    if ((addendum1 < Min || addendum1 > Max) || (addendum2 < Min || addendum2 > Max))// если операнды не принадлежат допустимому диапазону чисел, то ввод не происходит
                    {
                        symbol = (char)Keys.None;
                    }

                    if (AfterCommaDigits == 2)// если число цифр после запятой равно 2 то ввод не происходит
                    { 
                            symbol = (char)Keys.None;   
                    }

                        if (AfterCommaMark && Char.IsDigit(symbol))// Если происходит ввод после запятой и вводимый символ - цифра
                    {
                        AfterCommaDigits++;// инкрементация кол-ва цифер после запятой
                        if (AfterCommaDigits == 2)// если число цифр после запятой равно 2, то метка ввода после запятой снимается 
                        {
                            AfterCommaMark = false;
                        }
                    }

                   
                
                }
                // только для ","
                if (symbol == ',') 
                {
                    if ((addendum1 <= Min || addendum1 >= Max) || (addendum2 <= Min || addendum2 >= Max))// если операнды не входят в допустимый диапазон
                    {
                        AfterCommaMark = false;//отмена метки ввода после запятой
                        symbol = (char)Keys.None;// пустой символ
                        goto l;// перейти в конец
                    }
                    if (AfterCommaDigits < 2 && AfterCommaMark)// Если количество цифр после запятой меньше 2 и установлена метка ввода после запятой
                    {
                        AfterCommaMark = false;//отмена метки ввода после запятой
                        symbol = (char)Keys.None;// пустой символ
                        goto l;// перейти в конец
                    }
                    AfterCommaDigits = 0;// количество цифр после запятой обнуляется
                    AfterCommaMark = true;// устанавливается метка ввода после запятой 
                    if (s.Length == 0)// если длинна строки равно нулю
                    {
                        symbol = (char)Keys.None;// пустой символ
                        AfterCommaMark = false;// убирается метка ввода после запятой
                    }
                    else
                    {
                        if (!Char.IsDigit(s[s.Length - 1]) && s[s.Length-1]!= ')' ||s[s.Length - 1] == ',')// если последний символ в строке - не цифра и запятая
                        {
                            symbol = (char)Keys.None;// пустой символ
                            AfterCommaMark = false;// убирается метка ввода после запятой
                        }
                    }
                    
                }
                
                if (symbol == '-' || symbol == '+' || symbol == '/' || symbol == '*')// если символ - оператор
                {
                    if (s.Length > 0 && s[s.Length - 1] == '-')// если длинна строки больше нуля и в конце строки стоит минус, то оператор невозможно ввести
                    {
                        symbol = (char)Keys.None;
                    }
                    if (AfterCommaDigits == 0&&s.IndexOf(',',0,s.Length)!=-1)// если кол-во цифр после запятой = 0 и есть запятая
                    {
                        symbol = (char)Keys.None;// пустой символ
                        goto l;// перейти в конец
                    }
                    AfterCommaMark = false;// метка ввода после запятой убирается
                    AfterCommaDigits = 0;// обнуляется кол-во цифр после запятой
                    if (symbol != '-' && Field.Text.Length == 0)// если символ - не "-" и длинна строки равна нулю то ввод не происходит
                    {
                        symbol = (char)Keys.None;
                        goto l;
                    }
                    s = Field.Text;

                    if (s.IndexOf('-', 0, s.Length) != -1 || s.IndexOf('+', 0, s.Length) != -1 || s.IndexOf('*', 0, s.Length) != -1 || s.IndexOf('/', 0, s.Length) != -1)// если в строке есть оператор
                    {
                        if (!(s.IndexOf('-', 0, s.Length) == 0))// если в начале нету минуса - отмена ввода
                        {              
                            symbol = (char)Keys.None;
                        }
                        if (s.IndexOf('-', 0, s.Length) > 0|| s.IndexOf('*', 0, s.Length) > 0|| s.IndexOf('/', 0, s.Length) > 0|| s.IndexOf('+', 0, s.Length) > 0)// если операторы находятся не на нулевом индексе - отмена ввода
                        {
                            symbol = (char)Keys.None;
                        }
                    }
                }
                if (Field.Text.Contains("sqrt("))// если введена операция квадратного корня
                {
                    if (Char.IsDigit(symbol) || symbol ==',')// если символ - цифра или запятая
                    {
                        if (addendum1 < Min || addendum1 > Max)// если операнд не входит в допустимый диапазон значений - отмена ввода
                        {
                            return;
                        }
                        Field.Text = Field.Text.Insert(Field.Text.IndexOf(')'), symbol.ToString());// иначе - вставка символа между скобками
                    }
                        return; // выход из метода
                }
                if (Field.Text.Contains("sin("))// аналогично с операцией квадратного корня
                {
                    if (Char.IsDigit(symbol) || symbol == ',')
                    {
                        if (addendum1 < Min || addendum1 > Max)
                        {
                            return;
                        }
                        Field.Text = Field.Text.Insert(Field.Text.IndexOf(')'), symbol.ToString());
                    }
                    return;
                }
            l: Field.Text += symbol;// добавление символа в строку
            }
        }

        /// <summary>
        /// обработка ввода с клавиатуры (проверка символов происходит аналогично с методом AddText - отличие в способе отмены ввода символа и не нужно вручную добавлять символ с помощью кода)
        /// также при нажатии на кнопку Enter на клавиатуре происходит вычисление результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            addendum1 = (Min + Max) / 2; addendum2 = (Min + Max) / 2;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == (char)Keys.Back || e.KeyChar == ',')
            {
                string s = Field.Text;
                if (s.Contains('='))
                {
                    Field.Text = s.Substring(s.IndexOf('=') + 2);
                    Field.SelectionStart = Field.TextLength;
                    return;
                }
                if (e.KeyChar == (char)Keys.Back)
                {
                    if (s.Length == 0)
                    {
                        e.KeyChar = (char)Keys.None;
                        return;
                    }
                    if(s[s.Length-1] == ',')
                    {
                        AfterCommaMark = false;
                        return;
                    }
                }
                if (((!(s.Contains("sqrt") || s.Contains("sіn"))) && Field.SelectionStart == s.Length) || ((s.Contains("sqrt") || s.Contains("sіn")) && Field.SelectionStart != s.Length))
                {
                    if (s.Length > 0)
                    {


                        if (s.IndexOf('-', 0, s.Length) > 0 || s.IndexOf('-', 1, s.Length - 1) > 0 || s.IndexOf('+', 0, s.Length) != -1 || s.IndexOf('*', 0, s.Length) != -1 || s.IndexOf('/', 0, s.Length) != -1)
                        {

                            double.TryParse(s.Substring(s.LastIndexOfAny(actions) + 1) + e.KeyChar, out addendum2);
                            if (s[s.LastIndexOfAny(actions)] == '-')
                            {
                                addendum2 *= -1;
                            }
                        }

                        double.TryParse(s + e.KeyChar, out addendum1);

                        if (s.Contains("sqrt("))
                        {
                            double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)) + e.KeyChar, out addendum1);
                        }
                        if (s.Contains("sin("))
                        {
                            double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)) + e.KeyChar, out addendum1);
                        }
                    }
                    if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',')
                    {
                        if ((addendum1 < Min || addendum1 > Max) || (addendum2 < Min || addendum2 > Max))
                        {
                            if (e.KeyChar == ',')
                            {
                                AfterCommaMark = false;
                            }
                            e.KeyChar = (char)Keys.None;
                            return;
                        }
                        if (e.KeyChar == ',' && ((addendum1 < Min || addendum1 > Max) || (addendum2 < Min || addendum2 > Max)))
                            e.KeyChar = (char)Keys.None;
                        if (AfterCommaDigits == 2)
                            e.KeyChar = (char)Keys.None;
                        if (AfterCommaMark)
                        {
                            AfterCommaDigits++;
                            if (AfterCommaDigits == 2)
                            {

                                AfterCommaMark = false;
                            }
                        }
                    }
                    if (e.KeyChar == ',') // только для ","
                    { // i равно (-1) если "," еще нет в строке
                        if ((addendum1 <= Min || addendum1 >= Max) || (addendum2 <= Min || addendum2 >= Max))
                        {
                            e.KeyChar = (char)Keys.None;
                            AfterCommaMark = false;
                            return;
                        }
                        if (AfterCommaDigits < 2 && AfterCommaMark)
                        {
                            e.KeyChar = (char)Keys.None;
                            AfterCommaMark = false;
                            return;
                        }
                        AfterCommaDigits = 0;
                        AfterCommaMark = true;
                        if (s.Length == 0)
                        {
                            e.KeyChar = (char)Keys.None;
                            AfterCommaMark = false;
                        }
                        if (s.Length != 0)
                        {
                            if (!Char.IsDigit(s[s.Length - 1]))
                            {
                                e.KeyChar = (char)Keys.None;
                                AfterCommaMark = false;
                            }
                            if (s[s.Length - 1] == ',')
                            {
                                e.KeyChar = (char)Keys.None;
                                AfterCommaMark = false;
                            }
                        }

                    }

                    if (e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '/' || e.KeyChar == '*')
                    {

                        if (s.Length > 0 && s[s.Length - 1] == '-')
                        {
                            e.KeyChar = (char)Keys.None;
                        }
                        if (AfterCommaDigits == 0 && s.IndexOf(',', 0, s.Length) != -1)
                        {
                            e.KeyChar = (char)Keys.None;
                        }
                        AfterCommaMark = false;
                        AfterCommaDigits = 0;
                        if (e.KeyChar != '-' && Field.Text.Length == 0)
                        {
                            e.KeyChar = (char)Keys.None;

                        }
                        s = Field.Text;

                        if (s.IndexOf('-', 0, s.Length) != -1 || s.IndexOf('+', 0, s.Length) != -1 || s.IndexOf('*', 0, s.Length) != -1 || s.IndexOf('/', 0, s.Length) != -1)
                        {
                            if (!(s.IndexOf('-', 0, s.Length) == 0))
                            {

                                e.KeyChar = (char)Keys.None;
                            }
                            if (s.IndexOf('-', 0, s.Length) > 0 || s.IndexOf('*', 0, s.Length) > 0 || s.IndexOf('/', 0, s.Length) > 0 || s.IndexOf('+', 0, s.Length) > 0)
                            {
                                e.KeyChar = (char)Keys.None;
                            }
                        }
                    }
                    if (Field.Text.Contains("sqrt("))
                    {
                        if (Char.IsDigit(e.KeyChar))
                        {
                            if ((addendum1 < Min || addendum1 > Max) || (addendum2 < Min || addendum2 > Max))
                            {
                                e.KeyChar = (char)Keys.None;
                            }
                            if (Field.SelectionStart < Field.Text.IndexOf('(') || Field.SelectionStart > Field.Text.IndexOf(')'))
                            {
                                e.KeyChar = (char)Keys.None;
                            }
                        }
                        else
                        {
                            e.KeyChar = (char)Keys.None;
                        }

                    }
                    if (Field.Text.Contains("sin("))
                    {
                        if (Char.IsDigit(e.KeyChar))
                        {
                            if ((addendum1 < Min || addendum1 > Max) || (addendum2 < Min || addendum2 > Max))
                            {
                                e.KeyChar = (char)Keys.None;
                            }
                            if (Field.SelectionStart < Field.Text.IndexOf('(') || Field.SelectionStart > Field.Text.IndexOf(')'))
                            {
                                e.KeyChar = (char)Keys.None;
                            }
                        }
                        else
                        {
                            e.KeyChar = (char)Keys.None;
                        }

                    }

                }
                else { e.KeyChar = (char)Keys.None; }
            }
            else if(e.KeyChar == (char)Keys.Enter)
            {
                Result();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        #endregion

        #region valueEdition
        /// <summary>
        /// Обработчик события изменения минимального значения ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == '-' && MinValueBox.Text.Length == 0) || e.KeyChar == (char)Keys.Back))// если не вводится цифра либо знак минуса в начале строки либо отмена символа, то ввод не происходит
                e.KeyChar = (char)Keys.None;
            try
            {
                if (e.KeyChar == '\0')// если происходит нажатие на кнопку Enter происходит проверка на возможность присвоения введённого числа максимальному значению
                {
                    int tmp;
                    if ((tmp = int.Parse(MinValueBox.Text)) < Max) // если присваиваемое значение меньше максимального, то операция успешна и введённое значение заносится в переменную
                    {
                        Min = tmp;
                    }
                    else throw new ArgumentException("Min value must be less than Max value");// иначе генерируется исключение
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MinValueBox.Text = Min.ToString();
            }

        }

        /// <summary>
        /// Обработчик события изменения максимального значения ввода (Аналогично с MinValueBox_KeyPress, только вводимое значение должно быть больше минимального)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || e.KeyChar == (char)Keys.Back))
                e.KeyChar = (char)Keys.None;
            try
            {
                if (e.KeyChar == '\0')
                {
                    int tmp;
                    if ((tmp = int.Parse(MaxValueBox.Text)) > Min)
                    {
                        Max = tmp;
                    }
                    else { throw new Exception("Max value must be more than Min value"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MaxValueBox.Text = Max.ToString();

            }

        }

        #endregion

        #region deletion
        /// <summary>
        /// Обработчик события нажатия кнопки очистки. Очищает поле редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_button_Click(object sender, EventArgs e)
        {
            Field.Text = string.Empty;// очистка поля
            AfterCommaDigits = 0;// обнуление количества цифр после запятой
            AfterCommaMark = false;// снятие метки ввода после запятой
        }
        /// <summary>
        /// Обработчик нажатия кнопки отмены предыдущего символа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace_button_Click(object sender, EventArgs e)
        {
            if (Field.Text.Contains('s'))// если поле содержит операции sin(x) или sqrt (т.е содержит букву 's'), то удаление происходит внутри скобок
            {
                Field.Text = Field.Text.Substring(0, Field.Text.IndexOf(')')-1)+')';
                return;
            }
            if (Field.Text.Length != 0)// в остальных случаях при ненулевой длинне строки, текущая строка заменяется строкой без последнего символа
                Field.Text = Field.Text.Substring(0, Field.Text.Length - 1);

        }

        #endregion

        #endregion

        #region numButtons
        // кнопки для ввода чисел (цифры 0-9 и запятая) - вызывают метод AddText() с переданным аргументом в соответствии с символом за который кнопка отвечает
        
        private void Comma_button_Click(object sender, EventArgs e) { AddText(','); }

        private void button0_Click(object sender, EventArgs e) { AddText('0'); }

        private void button1_Click(object sender, EventArgs e) { AddText('1'); }

        private void button2_Click(object sender, EventArgs e) { AddText('2'); }

        private void button3_Click(object sender, EventArgs e) { AddText('3'); }

        private void button4_Click(object sender, EventArgs e) { AddText('4'); }

        private void button5_Click(object sender, EventArgs e) { AddText('5'); }

        private void button6_Click(object sender, EventArgs e) { AddText('6'); }

        private void button7_Click(object sender, EventArgs e) { AddText('7'); }

        private void button8_Click(object sender, EventArgs e) { AddText('8'); }

        private void button9_Click(object sender, EventArgs e) { AddText('9'); }

        #endregion

        #region operationButtons
        // кнопки ввода односимвольных операторов, работают аналогично с кнопками для чисел
        private void Plus_button_Click(object sender, EventArgs e) { AddText('+'); }

        private void Minus_button_Click(object sender, EventArgs e) { AddText('-'); }

        private void Multiplication_button_Click(object sender, EventArgs e) { AddText('*'); }

        private void Division_button_Click(object sender, EventArgs e) { AddText('/'); }
        /// <summary>
        /// Обработчик нажатия кнопки операции синуса (добавляет в поле строку "sin()"), затем происходит ввод между скобок
        /// Если до этого в поле было введено неотрицательное число, то в начало вставляется "sin(", затем число, после числа вставляется ")"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SinX_button_Click(object sender, EventArgs e)
        {  
            if (Field.Text.Contains('=')) { Field.Text = Field.Text.Substring(Field.Text.IndexOf('=') + 2); }// если до этого был получен результат в предыдущем выражении и не было очищено поле, то результат будет использован как операнд путём удаления всей строки до знака равенства включительно
            if (Field.Text.Contains('+') || Field.Text.LastIndexOf('-') > 0 || Field.Text.Contains('*') || Field.Text.Contains('/'))// если в строке содержатся операторы или минус не только в начале, то ввод не будет произведён
            {
                errorProvider.SetError(Field, "You can`t get sinus from this value");// установка индикатора ошибки
                return;
            }
            if (Field.Text == "")// если поле пустое, происходит ввод строки "sin()"
                Field.Text = "sin()";
            else if (Regex.IsMatch(Field.Text, "[0-9]*,?[0-9]{0,2}"))// иначе если строка в поле соответствует регулярному выражению (действительному неотрицательному числу), происходит вставка до открытой скобки перед числом и закрытие скобки после числа
            {
                Field.Text = Field.Text.Insert(0, "sin(");
                Field.Text += ')';
            }
        }
        /// <summary>
        /// Обработчик нажатия кнопки ввода операции 1/х, если до этого было введено число, то оно используется в качестве операнда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneDividedByX_button_Click(object sender, EventArgs e)
        {
            if (Field.Text.Contains('=')) { Field.Text = Field.Text.Substring(Field.Text.IndexOf('=') + 2); }// если до этого был получен результат в предыдущем выражении и не было очищено поле, то результат будет использован как операнд путём удаления всей строки до знака равенства включительно
            if (!(Field.Text.Contains('+') || Field.Text.Contains('/') || Field.Text.Contains('*') || Field.Text.LastIndexOf('-') > 0))// если поле не содержит операндов или минус стоит в начале, условие выполнятеся
            {
                if (Field.Text.Contains("sqrt()"))//если в строке есть операция квадратного корня, то операция 1/х вставляется в скобки
                {
                    Field.Text = Field.Text.Insert(5, "1/");
                    return;
                }
                if (Field.Text.Contains("sin()"))//если в строке есть операция синуса, то операция 1/х вставляется в скобки
                {
                    Field.Text = Field.Text.Insert(4, "1/");
                    return;
                }
                if (Field.Text == ""|| Field.Text == "-")// если строка пуста или в начале есть минус, то в поле просто добавлятся строка "1/"
                {
                    Field.Text += "1/";
                    return;
                }
                if (Regex.IsMatch(Field.Text, "[0-9]*"))// если в строке есть число
                {
                    if (Field.Text[0] == '-')// если в начале есть минус, то строка "1/" вставляется после минуса
                    {
                        Field.Text = Field.Text.Insert(1, "1/");
                    }
                    else// иначе в строку просто вставляется "1/"
                        Field.Text = Field.Text.Insert(0, "1/");
                }
            }
        }
        /// <summary>
        /// Обработчик нажатия кнопки ввода операции квадратного корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sqrt_button_Click(object sender, EventArgs e)
        {
            if (Field.Text.Contains('=')) { Field.Text = Field.Text.Substring(Field.Text.IndexOf('=') + 2); }
            if (Field.Text.Contains('+') || Field.Text.Contains('-') || Field.Text.Contains('*') || Field.Text.Contains('/'))
            {
                errorProvider.SetError(Field, "You can`t extract root from this value");
                return;
            }
            if (Field.Text == "")
                Field.Text = "sqrt()";
            else if (Regex.IsMatch(Field.Text, "[0-9]*"))
            {
                Field.Text = Field.Text.Insert(0, "sqrt(");
                Field.Text += ')';
            }
        }
        /// <summary>
        /// Обработчик нажатия кнопки знака равенства - при нажатии вызывается метод Result, который производит анализ строки и делает вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_button_Click(object sender, EventArgs e)
        {
            Result();
        }

        #endregion

        #region operations
        /// <summary>
        /// Метод, анализирующий строку: определение значений операндов, определение операции вычисления
        /// Вызывает методы вычисления из класса MyCalc
        /// </summary>
        private void Result()
        { 
            double result = 0;// обнуление переменной результата
            string s = Field.Text;
            if (!s.Contains('='))// вычисления будут проводиться, если строка не содержит знака равенства, иначе выводится сообщение об ошибке 
            {
                double addendum1 = default, addendum2 = default;// обнуление значений операндов
                if (s.Length > 0)// если длинна строки больше нуля, тогда возможно произвести анализ и вычисления
                {
                    if (Regex.IsMatch(s, @"-?[0-9]*,?[0-9]{0,2}[\+\-\/\*]{1}[0-9]*,?[0-9]{0,2}") && !s.Contains("sqrt(") && !s.Contains("sin("))// если строка соответствует шаблону простого выражения произвести определение значений двух операндов
                    {
                        if(!(double.TryParse(s.Substring(s.LastIndexOfAny(actions) + 1), out addendum2) && double.TryParse(s.Substring(0, s.LastIndexOfAny(actions)), out addendum1)))// если произвести преобразование не вышло, вывести сообщение об ошибке
                        {
                            errorProvider.SetError(Field, "Invalid input");// Индикация ошибки
                            return;
                        }
                    }
                    else if (s.Contains("s"))// если строка содержит букву s, то производится операция синуса или квадратного корня, то производтся вычиление только одного операнда в скобках
                    {
                        double.TryParse(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)), out addendum1);
                    }
                    else// иначе выводится сообщение об ошибке
                    {
                        errorProvider.SetError(Field, "Invalid input");
                        return;
                    }
                    if (s.Contains("sqrt"))// если в строке содержится подстрока "sqrt", тогда вызывается метод Sqrt() класса MyCalc 
                    {
                        result = MyCalc.Sqrt(addendum1);
                    }
                    if (s.Contains("sin"))// если в строке содержится подстрока "sin", тогда вызывается метод Sin() класса MyCalc 
                    {
                        result = MyCalc.Sin(addendum1);
                    }
                    else if (s.Contains('/'))// если в строке содержится слеш, тогда происходит операция деления, вызывается метод Div() класса MyCalc
                    {
                        try// если происходит деление на ноль, в методе Div() генерируется исключение и выводится сообщение об ошибке
                        {
                            result = MyCalc.Div(addendum1, addendum2);
                        }
                        catch (Exception ex)
                        {
                            errorProvider.SetError(Field, ex.Message);
                            return;
                        }
                    }
                    else if (s.Contains('*'))// если в строке содержится звёздочка, то происходит операция умножения, вызывается метод Mul() класса MyCalc 
                    {
                        result = MyCalc.Mul(addendum1, addendum2);
                    }
                    else if (s.Contains('+'))// если в строке содержится плюс, то происходит операция сложения, вызывается метод Add() класса MyCalc 
                    {
                        result = MyCalc.Add(addendum1, addendum2);
                    }
                    else if (s.Contains('-'))// если в строке содержится минус, то происходит операция вычитания, вызывается метод Sub() класса MyCalc 
                    {
                        result = MyCalc.Sub(addendum1, addendum2);
                    }

                    Field.Text += String.Format(" = {0}", Math.Round(result, 2));// полученный результат округляется до двух цифер после запятой, если есть, в строку добавляется знак равенства и результат
                    historyList.Items.Add(Field.Text);// в блок истории вычислений данной сессии добавляется новый элемент в виде всей строки из поля редкатирования ("выражение = результат")
                }
                else// если поле пустое
                {
                    errorProvider.SetError(Field, "Empty field");// выввод сообщения о пустом поле
                    return;
                }
            }
        }

        #endregion
    }
}