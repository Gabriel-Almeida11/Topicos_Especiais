using ControleContas.Model;
try
{

Cliente  = new Cliente("", "", );
    Banco  = new Banco("", );
    Agencia = new Agencia("", , );
    Conta  = new Conta(, , ,  );

    Cliente gabriel = new Cliente("Gabriel", "15346568900", "2001" );
    Banco santander = new Banco("Santander", "018" );
    Agencia CNB = new Agencia("27181272", 2000 , santander );
    Conta contaGb = new Conta(123456789, CNB , gabriel , 100 );

    Cliente almeida  = new Cliente("Almeida", "15344692912", "2000" );
    Banco bradesco  = new Banco(" Bradesco ", "019" );
    Agencia BNA  = new Agencia("23291453", 2001 , bradesco );
    Conta contaAL  = new Conta(183678591, BNA , almeida , 100 );

    contaGb.Deposito(500)

    Console.WriteLine($"{contaGb.ToString()}");
    Console.WriteLine($"{contaLC.ToString()}");


    Console.WriteLine("O saldo total das contas é " + (contaGb.Saldo + contaAL.Saldo ));

    Console.WriteLine($"A conta de maior saldo é {Conta._contaMaiorSaldo} cujo saldo é {Conta._maiorSaldo}");

}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}