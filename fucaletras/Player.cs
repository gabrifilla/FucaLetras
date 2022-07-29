using System;
using System.Data;
using System.Windows.Forms;
using FucaLetrasBD;
using FucaLetrasWeb;
using System.IO;
using TagLib;
using NAudio;

namespace fucaletras
{
    public partial class Player : Form
    {
        string[] pt, fl;
        string caminho = @"F:\Backup\Jogo\TCC\TCC\fucaletras 3.5 Final Version\fucaletras\musicas";

        private static string sub;
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut saida = null;


        public Player()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Criando a conexão com o banco de dados
            AcessoDados FcBd = new AcessoDados();

            //Cria uma instancia do diretório onde é encontrado as músicas.
            DirectoryInfo Dir = new DirectoryInfo(caminho);

            //Traz os arquivos de musica vindos do diretório acima.
            //"*.mp3" faz com que traga apenas arquivos .mp3, que no caso são as musicas.
            FileInfo[] Files = Dir.GetFiles("*.mp3", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                //Apresenta o nome dos arquivos vindos do diretório iformado inicialmente
                string FileName = File.Name.Replace(Dir.Name, "");
                //Insere os arquivos retirados do caminho na ListView
                LvMusic.Items.Add(FileName);
            }
        }
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda aju = new Ajuda();
            aju.Show();
        }

        private void sobreOSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sob = new Sobre();
            sob.Show();
        }

        private void editarPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlay ed = new EditPlay();
            ed.Show();
        }

        private void editarLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarLetra EdLetra = new EditarLetra(textBox1.Text);
            EdLetra.Show();
        }

        private void editarMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Faz com que a classe de EditarMusica receba um parâmetro com o valor da textbox para 
            que possa ser reconhecida para editar as informações */
            EditarMusica EdMusi = new EditarMusica(textBox1.Text);
            EdMusi.Show();
        }

        private void abrBtt_Click(object sender, EventArgs e)
        {
            //Bostão para procurar musicas separadas, da pasta original.
            //Caso o usuário queira abrir alguma musica de uma pasta separada, exemplo, ao invés de estar na pasta 'Music' ta na pasta 'Download'
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Multiselect = true;
            if (opfile.ShowDialog() == DialogResult.OK)
            {
                fl = opfile.SafeFileNames;
                pt = opfile.FileNames;
                for (int i = 0; i < fl.Length; i++)
                {
                    LvMusic.Items.Add(fl[i]);
                }
            }
        }

        private void bttPlay_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (saida != null)
            {
                if (saida.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    saida.Pause();
                    bttPlay.Text = "PAUSAR";
                }
                else if (saida.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    saida.Play();
                    bttPlay.Text = "TOCAR";
                }
            }
            try
            {
                //cria a string onde é encontrado o caminho da musica selecionada e passa esse caminho (encontrado na textbox) para a variavel criada
                string musica_selecionada = textBox1.Text;

                //condição para caso nenhuma musica esteja selecionada
                //OBJETIVO: TOCAR UMA MUSICA ALEATÓRIA QUE ESTEJA NA LIST
                if (textBox1.Text == "")
                {
                    //cria a váriavel para fazer a randomização de musicas na pasta de musica
                    var rand = new Random();
                    //recupera o caminho da musica
                    var soundFiles = Directory.GetFiles(caminho, "*.mp3");
                    //adiciona o número randomico a alguma das musicas e atribui qual a musica à variavel playSound
                    var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

                    //Passa como parametro para tocar a musica da variavel playSound
                    NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(playSound));
                    stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                    saida = new NAudio.Wave.DirectSoundOut();

                    saida.Init(stream);
                    saida.Play();

                }

                else
                {
                    open.FileName = musica_selecionada;
                    ////instancia um objeto da classe tag que faz referencia à musica selecionada na listView                
                    TagLib.File f = TagLib.File.Create(open.FileName);
                    f.Save();

                    //instancia um objeto da classe de dados
                    AcessoDados AcDa = new AcessoDados();
                    //Instancia um objeto da classe de dados da web
                    AcessoDadosWeb AcWe = new AcessoDadosWeb();

                    //Executa a procedure de inserir a musica no banco de dados a partir das Tags encontradas no arquivo .mp3
                    try
                    {
                        #region Tentativa de verificação
                        //public int Teste ()
                        //{
                        //object cond = 0;
                        //try
                        //{

                        //    AcessoDados dal = new AcessoDados();

                        //    //Adiciona os parametros para cada tag diferente.
                        //    //dal.AdicionarParametro("@nome_musica", nomeMusica);
                        //    //dal.AdicionarParametro("@duracao", 12);
                        //    //dal.AdicionarParametro("@letra", "fsadf");
                        //    //dal.AdicionarParametro("@nome_banda", f.Tag.Performers.ToString());
                        //    //dal.AdicionarParametro("@nome_genero", f.Tag.Genres.ToString());
                        //    //dal.AdicionarParametro("@caminho", textBox1.Text);
                        //    //dal.AdicionarParametro("@album", f.Tag.Album.ToString());
                        //    dal.ExecuteNonQuery("Novo_Cadastro");

                        //    cond = 1;
                        //    return cond;

                        //}
                        //catch (Exception ex)
                        //{

                        //    if (ex.Message.Contains("UK_user_senha"))
                        //    {
                        //        cond = 0;
                        //        return cond;
                        //    }
                        //    else
                        //    {
                        //        cond = 0;

                        //        return cond;
                        //    }
                        //}

                        #endregion

                        //Método para Tocar a musica
                        DisposeWave();
                        open.FileName = textBox1.Text;
                        NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                        stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                        saida = new NAudio.Wave.DirectSoundOut();

                        saida.Init(stream);

                        saida.Play();

                        //Adiciona os parametros para trazer a letra
                        AcWe.AdicionarParametro("@caminho", textBox1.Text);
                        DataTable dat = AcWe.ExecutarConsulta(CommandType.StoredProcedure, "BuscarLetra");

                        if (dat.Rows.ToString() == "")
                        {
                            AcDa.AdicionarParametro("@nome", f.Tag.Title.ToString());
                            AcDa.AdicionarParametro("@duracao", Convert.ToInt32(f.Tag.TrackCount));
                            AcDa.AdicionarParametro("@nome_banda", f.Tag.Performers.ToString());
                            AcDa.AdicionarParametro("@nome_genero", f.Tag.Genres.ToString());
                            AcDa.AdicionarParametro("@caminho", textBox1.Text);
                            AcDa.AdicionarParametro("@nome_album", f.Tag.Album.ToString());
                            AcDa.InserirMusica(CommandType.StoredProcedure, "insertMusNoLetra");
                        }
                        else
                        {

                            //Adiciona os parametros para cada tag diferente.
                            AcDa.AdicionarParametro("@nome", f.Tag.Title.ToString());
                            AcDa.AdicionarParametro("@duracao", Convert.ToInt32(f.Tag.TrackCount));
                            AcDa.AdicionarParametro("@letra", dat.Rows[0][0].ToString());
                            AcDa.AdicionarParametro("@nome_banda", f.Tag.Performers.ToString());
                            AcDa.AdicionarParametro("@nome_genero", f.Tag.Genres.ToString());
                            AcDa.AdicionarParametro("@caminho", textBox1.Text);
                            AcDa.AdicionarParametro("@nome_album", f.Tag.Album.ToString());

                            //executa a procedure para inserir as informações
                            AcDa.InserirMusica(CommandType.StoredProcedure, "insertMusica");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não Foi possível tocar a musica, " + ex);
                    }

                    LblArtista.Text = f.Tag.Performers.ToString();
                    LblMusica.Text = f.Tag.Title;
                }

                // Carrega LetraRtxt
                AcessoDados ad = new AcessoDados();

                ad.AdicionarParametro("@caminho", textBox1.Text);
                DataTable dt = ad.ExecutarConsulta(CommandType.StoredProcedure, "BuscarLetra");

                letraRTxt.Text = dt.Rows[0][0].ToString();

            }

            catch (Exception err)
            {
                MessageBox.Show("erro " + err.Message);
            }
        }

        //Método para fazer com que saia o som
        private void DisposeWave()
        {
            if (saida != null)
            {
                if (saida.PlaybackState == NAudio.Wave.PlaybackState.Playing) saida.Stop();
                saida = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void LvMusic_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string musica_selecionada;
                musica_selecionada = caminho + sub + @"\" + LvMusic.FocusedItem.Text;

                //Passa o caminho da musica selecionada na list para uma textbox
                textBox1.Text = musica_selecionada.ToString();

                //atribui o que tem dentro da textbox à variavel Valor
                string Valor = textBox1.Text;

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro no evento click " + err.Message);

            }
        }

        private void randBtt_Click(object sender, EventArgs e)
        {
            //cria a váriavel para fazer a randomização de musicas na pasta de musica
            var rand = new Random();
            //recupera o caminho da musica
            var soundFiles = Directory.GetFiles(caminho, "*.mp3");
            //adiciona o número randomico a alguma das musicas e atribui qual a musica à variavel playSound
            var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

            //Passa como parametro para tocar a musica da variavel playSound
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(playSound));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            saida = new NAudio.Wave.DirectSoundOut();

            try
            {

                //condição para caso já tenha alguma musica tocando...
                if (saida.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    //para a musica que esta tocando
                    saida.Stop();
                }
                else
                {
                    saida.Init(stream);

                    saida.Play();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeWave();
        }

        private void ForwardBtt_Click(object sender, EventArgs e)
        {
            int selectedIndex = LvMusic.SelectedIndices[0];
            selectedIndex++;
            LvMusic.Items[selectedIndex].Selected = true;
            LvMusic.Items[selectedIndex].Focused = true;

            string nome1, nome2;
            nome1 = caminho + sub + @"\" + LvMusic.Items[selectedIndex].ToString().Replace("ListViewItem: ", "");
            nome2 = nome1.Replace("{", "");
            textBox1.Text = nome2.Replace("}", "");


            OpenFileDialog op = new OpenFileDialog();
            op.FileName = textBox1.Text;

            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(op.FileName));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            saida = new NAudio.Wave.DirectSoundOut();

            if (saida.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                //para a musica que esta tocando
                saida.Stop();
            }
            else
            {
                saida.Init(stream);

                saida.Play();
            }
            bttPlay.Text = "PAUSAR";
        }

        private void BttVoltar_Click(object sender, EventArgs e)
        {
            int selectedIndex = LvMusic.SelectedIndices[0];
            selectedIndex--;
            LvMusic.Items[selectedIndex].Selected = true;
            LvMusic.Items[selectedIndex].Focused = true;

            string nome1, nome2;
            nome1 = caminho + sub + @"\" + LvMusic.Items[selectedIndex].ToString().Replace("ListViewItem: ", "");
            nome2 = nome1.Replace("{", "");
            textBox1.Text = nome2.Replace("}", "");


            OpenFileDialog op = new OpenFileDialog();
            op.FileName = textBox1.Text;

            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(op.FileName));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            saida = new NAudio.Wave.DirectSoundOut();

            if (saida.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                //para a musica que esta tocando
                saida.Stop();
            }
            else
            {
                saida.Init(stream);

                saida.Play();
            }

            bttPlay.Text = "PAUSAR";
        }
    }
}
