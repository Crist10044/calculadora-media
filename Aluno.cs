using System;

class Aluno 
{

    public string nome;
    public double nota1,nota2;
    
    public Aluno(string nome, double nota1, double nota2)
    {
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

    public double media()
    {
        return (nota1+nota2)/2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);

        Console.WriteLine("{0} está {1} com média {2}",nome,obterSituacao,obterMedia);
    }

}