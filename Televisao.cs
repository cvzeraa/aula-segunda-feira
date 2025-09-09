public class Televisao
{
    
    public float Tamanho { get; set; }
    public int Resoluçao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
    private bool Mudo {get; set; }
    private int UltimoCanal {get; set; }

    //TV
    private const int VolumeMinimo = 0;
    private const int VolumeMaximo = 100;
    private const int CanalMinimo = 1;
    private const int CanalMaximo = 520;


    public Televisao(float tamanho){
        Tamanho = tamanho;
        Volume = 50;
        Canal = 1;
        UltimoCanal = 1;
        Estado = false;
        Mudo = false;
    }

    //ESTADO
    public void Ligar() {
        Estado = true;
        Canal = UltimoCanal;
        Console.WriteLine($"TV ligada no canal {Canal}");
    }

    public void Desligar(){
        Estado = false;
        UltimoCanal = Canal;
        Console.WriteLine("TV desligada");
    }

    //VOLUME
    public void AumentarVolume(){
        if(Volume < VolumeMaximo)
    {
        Volume++;
        Console.WriteLine($"Volume: {Volume}");
    }
    else
        {
        Console.WriteLine("Volume já está no máximo");
        }
    }
    public void DiminuirVolume(){
        if(Volume > VolumeMinimo)
    {
        Volume--;
        Console.WriteLine($"Volume: {Volume}");
    }
    else
        {
            Console.WriteLine("Volume já está no mínimo");
        }
    }

    public void AtivarMudo(){
        Mudo = !Mudo;
        if(Mudo)
            Console.WriteLine("Mudo ativado");
        else   
            Console.WriteLine("Mudo Desativado. Volume atual: {Volume}");
    }

   //CANAL
   public void IrParaCanal(int numero){
    if(numero>= CanalMinimo && numero <= CanalMaximo)
    {
        Canal = numero;
        UltimoCanal = numero;
        Console.WriteLine($"Canal alterado para {Canal}");
    }
    else
    {
        Console.WriteLine("Número de canal inválido");
    }
}

    public void ProximoCanal(){
        Canal = (Canal < CanalMaximo) ? Canal + 1 : CanalMinimo;
        UltimoCanal = Canal;
        Console.WriteLine($"Canal alterado para {Canal}");
    }

    public void CanalAnterior(){
        Canal = (Canal > CanalMinimo) ? Canal - 1 : CanalMaximo;
        UltimoCanal = Canal;
        Console.WriteLine($"Canal alterado para {Canal}");
    }

