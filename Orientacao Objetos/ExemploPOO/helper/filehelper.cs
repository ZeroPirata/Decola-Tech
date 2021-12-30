using System.IO;
// Após o * se adicionar .[algumacoisa] ira buscar arquivos que possuam o formato do arquivo desejado
// o * tem a mesma funcionalidade do % do python/MySQL
namespace ExemploPOO.helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.TopDirectoryOnly);
            foreach (var paths in retornoCaminho)
            {
                System.Console.WriteLine(paths);
            }
        }
        public void ListarArquivosDiretorio(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);
            foreach (var paths in retornoArquivos)
            {
                System.Console.WriteLine(paths);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
        }
        public void ApagarDiretorio(string caminho)
        {
            Directory.Delete(caminho);
        }
        public void CriarArquivodeTxt(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }
        public void CriarArquivodeTxtStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void adicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
        public void adicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerarquivoStream(string caminho)
        {
            string? linha = string.Empty;
            using(var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho,  bool sobescrever)
        {
            File.Move(caminho, novoCaminho, sobescrever);
        }
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobescrever)
        {
            File.Copy(caminho, novoCaminho,sobescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}