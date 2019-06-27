using System;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpfus, cpfcalc;
            int peso10=10, peso11=11, resto=0, resultado=0;
            
            Console.WriteLine ("Insira seu CPF!");
                cpfus = Console.ReadLine(); 

/* Para pegar os 9 primeiros digitos do CPF utilizamos o comando "Substring" este comando nos ajuda a "quebrar" uma string e pegar caracter a caracter
 de uma string, a primeira parte do comando "Substring" é a posição de onde irá iniciar a captura dos caracteres, a segunda parte será a quantidade de
 caracteres que serão obtidos a partir da posição que foi inserida. */
            cpfcalc = cpfus.Substring(0,9);
//                Console.WriteLine(cpfcalc);

/* Abaixo estamos imprimindo em tela a primeira posição do número do CPF, neste caso estamos usando a posição 0. */
//            Console.WriteLine(cpfcalc[0]);

/* Estamos usando o laço "for" para obter um número por vez do CPF e multiplicar pelos pesos de 10 a 2.
Como são 9 números realizamos a contagem no "for" a partir do zero(0) e indo até 8, que totaliza 9 números. */
            for (int i = 0 ; i <= 8 ; i++){
//               Console.WriteLine(cpfcalc[i]);

/* Para realizar a multiplicação dos números do CPF com os pesos de 10 a 2 é necessário pegar um número por vez e converter para número e logo
em seguida multiplicar pelo peso. O problema é que a conversão para inteiro só é possível com valores string, no entanto quando foi retirado o caracter da string,
não é possível converter para inteiro, pois "int.parse" só converte string. Sendo assim, foi necessário converter o caracter obtido em string com o 
comando "cpfcalc[i].ToString()". Depois de convertido para string é possível converter para inteiro e realizar a multiplicação.  */
//                    Console.WriteLine(int.Parse(cpfcalc[i].ToString())*peso10);

/* Faremos a multiplicação de cada número do CPF pelo peso de 10 a 9 e guardamos o resultado na variável resultado. */
                        resultado += int.Parse(cpfcalc[i].ToString())*peso10;

/* Estamos realizando a decrementação da variável peso 10, ou seja, retirando 1 a cada volta do laço. */
                            peso10--;
            }
//            Console.WriteLine (resultado);

/* Obter o resultado e dividir por 11 e guardar o resto da divisão na variável resto. */
            resto = resultado % 11;


/* Se o resto da divisão for menor que 2, então o digito verificador do CPF será 0, caso contrário, o digito será o resultado da subtração de 11 pelo
resto. */
                if (resto < 2){
                    cpfcalc = cpfcalc + 0;            
                }
                else{
                    cpfcalc = cpfcalc + (11-resto);
                }
//                Console.WriteLine(cpfcalc);

/* Estamos zerando a variável resultado para iniciar o próximo cálculo. */
                resultado = 0;

                for (int i = 0 ; i <= 9 ; i++){
                     resultado += int.Parse(cpfcalc[i].ToString())*peso11;
                     peso11--;

                }
                resto = resultado % 11;

                if (resto < 2) {
                    cpfcalc = cpfcalc + 0;
                }
                else{
                    cpfcalc = cpfcalc + (11-resto);
                }
//                Console.WriteLine(cpfcalc);
                if(cpfus.Equals(cpfcalc)){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu CPF é válido!");                  
                }

                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu CPF é inválido!");               
                }
                Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
