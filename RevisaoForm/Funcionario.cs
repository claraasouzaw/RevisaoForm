using System;

public class Funcionario
{
    public string nome;
    public string cpf;
    public string email;
    public double salario;
    public string funcao;

    public double CalcularSalario()
    {
        if (this.funcao == "Médico")
        {
            this.salario += salario * 20 / 100;
        }
        else if (this.funcao == "TI")
        {
            this.salario += 5600;
        }
        else if (this.funcao == "Adm")
        {
            this.salario += salario * 15 / 100;
        }

       return this.salario;
    }


}
