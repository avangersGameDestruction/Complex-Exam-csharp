# Complex-Exam-csharp

![Test](https://imgur.com/OhalWOj)



Data Member
1
a
 double
2
b
double


Methods
1
Add(Complex Num2)
Add Method to add to numbers.
Suppose :     Num1= a+bi               Num2=c+di           Sum=(a+c)+(b+d)i
2
Sub(Complex Num2)
Sub Method to subtract to numbers.
Suppose :     Num1= a+bi               Num2=c+di           Sub=(a-c)+(b-d)i
3
Mul(Complex Num2)
Mul Method to multiplicate  to numbers.
Suppose :     Num1= a+bi               Num2=c+di
Mul=(a*c-b*d)+(b*c+a*d)i


Div(Complex Num2))
Div Method to divide to numbers.
Suppose :     Num1= a+bi               Num2=c+di
Div=(a*c+b*d)/(c*c+d*d)+(b*c-a*d)i/(c*c+d*d)

PART 2: Test the Complex Class
Build a simple windows form that:
Allow the user to insert two Complex Numbers, the user have to insert values in this format (a+bi),(c+di) and have to be notified if not. 
2. Split string that inserted based on the following delimiters:{ ' ', '(', ')', 'i', ',' }
For Example: (-9+3i),(10-6i) 
First Complex Number = -9+3i. 
[ a= -9 b=3 ]
Second Complex Number= 10-6i.
[ a= 10 b= -6 ]

Allow the user to perform the mathematical operations (+, -, *, /).

1 create the form 
needed 4 textboxes 5 buttons 2 labels

on the first button the split button add the following code to split the 2 ints 
```csharp
private void btnSplit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSplitNumber.Text)
                && IsValidString(txtSplitNumber.Text))
            {
                string[] numbers = txtSplitNumber.Text.Split(',');
                txtFirstNumber.Text = numbers[0].Replace("(", "").Replace(")", "");
                txtSecondNumber.Text = numbers[1].Replace("(", "").Replace(")", "");
                
            }
            else
                MessageBox.Show("pattern isn't correct");
        }
 ```
then we gonna code the following functions

string checker 
```csharp
private bool IsValidString(string text) =>
            !Regex.IsMatch(text.Trim(),
                @"^$\([0-9]{1,5}\-|\+[0-9]{1,5} [i] \)\,\([0-9]{1,5}\+|\-[0-9]{1,5} [i] \)");
```

div btn

```csharp
private string Div(string firstNumber, string secondNumber)
        {
            string result = "";
            double a, b, c, d;
            a = double.Parse(firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-')));
            b = double.Parse(firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2).Replace("i",""));
            c = double.Parse(secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-')));
            d = double.Parse(secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2).Replace("i", ""));
            result = $"{Math.Round(( (a * c + b * d) / (c * c - Math.Abs(a * d)) ) , 2)} + { Math.Round( (b * c - Math.Abs((a * d))) / (c * c + d * d) , 2)}i ";
            return result;
        }
```
sub btn

```csharp
private string Sub(string firstNumber, string secondNumber)
        {
            string result = "";
            string a, b, c, d;
            a = firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'));
            b = firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2);
            c = secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'));
            d = secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2);
            result = $"{double.Parse(a) - double.Parse(c.Replace("i", ""))} + {double.Parse(b.Replace("i", "")) - Math.Abs(double.Parse(d.Replace("i", "")))}i";
            return result;
        }
```
mul btn

```csharp
private string Mul(string firstNumber, string secondNumber)
        {
            string result = "";
            double a, b, c, d;
            a = double.Parse(firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-')));
            b = double.Parse(firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2).Replace("i", ""));
            c = double.Parse(secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-')));
            d = double.Parse(secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2).Replace("i", ""));
            result =$"{a * c - Math.Abs(b * d) } + { (b * c) - Math.Abs(a * d)}i";
            return result;
        }
```
add btn

```csharp
private string Add(string firstNumber , string secondNumber)
        {
            string result = "";
            string a, b, c, d;
            a = firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'));
            b = firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-') , firstNumber.Length - 2);
            c = secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'));
            d = secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2);
            result = $"{double.Parse(a) + double.Parse(c.Replace("i",""))} + {double.Parse(b.Replace("i", "")) - double.Parse(d.Replace("i", ""))}i";
            return result;
        }
```

this is the full solution for the test / exam
