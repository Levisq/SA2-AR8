namespace ER2
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        public endereco endereco { get; set; }

        public abstract void PagarImposto(float salario);
        
    }
}         