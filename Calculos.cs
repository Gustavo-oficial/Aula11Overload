namespace Aula11Overload
{
    public class Calculos
    {
     public string Calcular(){
         return "Calculando...";
     }   
        public int Calcular(int num1){
           return num1;
        }
	public int Calcular(int num1, int num2){
        return num1 + num2;
    }
	public string Calcular(string num1, string num2){
        return $"{num1} + {num2} = ";
    }
    }
}