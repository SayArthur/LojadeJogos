using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojadeJogos.Repositorio;
using MySql.Data.MySqlClient;
using LojadeJogos.Models;

namespace LojadeJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarGame(ModelGame jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tblJogo values(@gamename, @gamegender, @gamedev, @gamecod, @gamelan, @gameversion, @gamesinopse, @gameplat, @gameidade)", con.ConectarBd());
            cmd.Parameters.Add("@gamename", MySqlDbType.VarChar).Value = jogo.GameName;
            cmd.Parameters.Add("@gamegender", MySqlDbType.VarChar).Value = jogo.GameGender;
            cmd.Parameters.Add("@gamedev", MySqlDbType.VarChar).Value = jogo.GameDev;
            cmd.Parameters.Add("@gamecod", MySqlDbType.VarChar).Value = jogo.GameCod;
            cmd.Parameters.Add("@gamelan", MySqlDbType.VarChar).Value = jogo.GameLan;
            cmd.Parameters.Add("@gameversion", MySqlDbType.VarChar).Value = jogo.GameVersion;
            cmd.Parameters.Add("@gamesinopse", MySqlDbType.VarChar).Value = jogo.GameSinopse;
            cmd.Parameters.Add("@gameplat", MySqlDbType.VarChar).Value = jogo.GamePlat;
            cmd.Parameters.Add("@gameidade", MySqlDbType.VarChar).Value = jogo.GameIdade;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

        public ModelGame ListarCodGame(int cod)
        {
            var comando = String.Format("select * from tblJogo where GameCod = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosJogo = cmd.ExecuteReader();
            return ListCodGame(DadosJogo).FirstOrDefault();
        }

        public List<ModelGame> ListCodGame(MySqlDataReader dt)
        {
            var AltAl = new List<ModelGame>();
            while (dt.Read())
            {
                var AlTemp = new ModelGame()
                {
                    GameName = dt["gamename"].ToString(),
                    GameGender = dt["gamegender"].ToString(),
                    GameDev = dt["gamedev"].ToString(),
                    GameCod = int.Parse(dt["gamecod"].ToString()),
                    GameLan = int.Parse(dt["gamelan"].ToString()),
                    GameVersion = dt["gameversion"].ToString(),
                    GameSinopse = dt["gamesinopse"].ToString(),
                    GamePlat = dt["gameplat"].ToString(),
                    GameIdade = dt["gameidade"].ToString()
                };
                
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<ModelGame> ListarGame()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tblJogo", con.ConectarBd());
            var DadosJogos = cmd.ExecuteReader();
            return ListarTodosGames(DadosJogos);
        }

        public List<ModelGame> ListarTodosGames(MySqlDataReader dt)
        {
            var TodosJogos = new List<ModelGame>();
            while (dt.Read())
            {
                var JogoTemp = new ModelGame()
                {
                    GameName = dt["gamename"].ToString(),
                    GameGender = dt["gamegender"].ToString(),
                    GameDev = dt["gamedev"].ToString(),
                    GameCod = int.Parse(dt["gamecod"].ToString()),
                    GameLan = int.Parse(dt["gamelan"].ToString()),
                    GameVersion = dt["gameversion"].ToString(),
                    GameSinopse = dt["gamesinopse"].ToString(),
                    GamePlat = dt["gameplat"].ToString(),
                    GameIdade = dt["gameidade"].ToString()
                };
                TodosJogos.Add(JogoTemp);
            }
            dt.Close();
            return TodosJogos;
        }

        public void CadastrarCli(ModelCi cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.DtCliNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tblCliente values(@cliname, @cliend, @clicpf, @clinum, @cliemail, @clinascdt)", con.ConectarBd());
            cmd.Parameters.Add("@cliname", MySqlDbType.VarChar).Value = cliente.CliName;
            cmd.Parameters.Add("@cliend", MySqlDbType.VarChar).Value = cliente.CliEnd;
            cmd.Parameters.Add("@clicpf", MySqlDbType.DateTime).Value = cliente.CliCpf;
            cmd.Parameters.Add("@clinum", MySqlDbType.VarChar).Value = cliente.CliNum;
            cmd.Parameters.Add("@cliemail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("@clinascdt", MySqlDbType.VarChar).Value = data_sistema;
            con.DesconectarBd(); 

        }

        public ModelCi ListarCodCli(int cod)
        {
            var comando = String.Format("select * from tblCliente where CliCpf = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosCliente = cmd.ExecuteReader();
            return ListCodCli(DadosCliente).FirstOrDefault();
        }

        public List<ModelCi> ListCodCli(MySqlDataReader dt)
        {
            var AltAl = new List<ModelCi>();
            while (dt.Read())
            {
                var AlTemp = new ModelCi()
                {
                    CliName = dt["cliname"].ToString(),
                    CliEnd = dt["cliend"].ToString(),
                    CliCpf = dt["clicpf"].ToString(),
                    CliNum = dt["clinum"].ToString(),
                    CliEmail = dt["cliemail"].ToString(),
                    DtCliNasc = DateTime.Parse(dt["clinascdt"].ToString()),
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<ModelCi> ListarCli()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbl_Cliente", con.ConectarBd());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCli(DadosCliente);
        }

        public List<ModelCi> ListarTodosCli(MySqlDataReader dt)
        {
            var TodosClientes = new List<ModelCi>();
            while (dt.Read())
            {
                var ClienteTemp = new ModelCi()
                {
                    CliName = dt["cliname"].ToString(),
                    CliEnd = dt["cliend"].ToString(),
                    CliCpf = dt["clicpf"].ToString(),
                    CliNum = dt["clinum"].ToString(),
                    CliEmail = dt["cliemail"].ToString(),
                    DtCliNasc = DateTime.Parse(dt["clinascdt"].ToString()),
                };
                TodosClientes.Add(ClienteTemp);
            }
            dt.Close();
            return TodosClientes;
        }

        public void CadastrarFunc(ModelFunc func)
        {
            string data_sistema = Convert.ToDateTime(func.DtFuncNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbl_Func values(@funcname, @funccargo, @funccod, @funcemail, @funcnum, @funcrg, @funccpf, @funcend, @funcnascdt)", con.ConectarBd());
            cmd.Parameters.Add("@funcname", MySqlDbType.VarChar).Value = func.FuncName;
            cmd.Parameters.Add("@funccargo", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.Parameters.Add("@funccod", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.Parameters.Add("@funcemail", MySqlDbType.VarChar).Value = func.FuncEmail;
            cmd.Parameters.Add("@funcnum", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@funcrg", MySqlDbType.VarChar).Value = func.FuncRg;
            cmd.Parameters.Add("@funccpf", MySqlDbType.VarChar).Value = func.FuncCpf;
            cmd.Parameters.Add("@funcend", MySqlDbType.VarChar).Value = func.FuncEnd;
            cmd.Parameters.Add("@funcnascdt", MySqlDbType.VarChar).Value = func.DtFuncNasc;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

        public ModelFunc ListarCodFunc(int cod)
        {
            var comando = String.Format("select * from tblFunc where FuncCod = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosFunc = cmd.ExecuteReader();
            return ListCodFuncionario(DadosFunc).FirstOrDefault();
        }

        public List<ModelFunc> ListCodFuncionario(MySqlDataReader dt)
        {
            var AltAl = new List<ModelFunc>();
            while (dt.Read())
            {
                var AlTemp = new ModelFunc()
                {
                    FuncName = dt["funcname"].ToString(),
                    FuncCargo = dt["funccargo"].ToString(),
                    FuncCod = int.Parse(dt["funccod"].ToString()),
                    FuncEmail = dt["funcemail"].ToString(),
                    FuncNum = dt["funcnum"].ToString(),
                    FuncRg = dt["funcrg"].ToString(),
                    FuncCpf = dt["funccpf"].ToString(),
                    FuncEnd = dt["funcend"].ToString(),
                    DtFuncNasc = DateTime.Parse(dt["funcnascdt"].ToString()),
                };

                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<ModelFunc> ListarFunc()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbl_Func", con.ConectarBd());
            var DadosFunc = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosFunc);
        }

        public List<ModelFunc> ListarTodosFuncionarios(MySqlDataReader dt)
        {
            var TodosFuncs = new List<ModelFunc>();
            while (dt.Read())
            {
                var FuncTemp = new ModelFunc()
                {
                    FuncName = dt["funcname"].ToString(),
                    FuncCargo = dt["funccargo"].ToString(),
                    FuncCod = int.Parse(dt["funccod"].ToString()),
                    FuncEmail = dt["funcemail"].ToString(),
                    FuncNum = dt["funcnum"].ToString(),
                    FuncRg = dt["funcrg"].ToString(),
                    FuncCpf = dt["funccpf"].ToString(),
                    FuncEnd = dt["funcend"].ToString(),
                    DtFuncNasc = DateTime.Parse(dt["funcnascdt"].ToString()),
                };
                TodosFuncs.Add(FuncTemp);
            }
            dt.Close();
            return TodosFuncs;
        }

    }
}