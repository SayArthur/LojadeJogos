using LojadeJogos.Repositorio;
using MySql.Data.MySqlClient;
using LojadeJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojadeJogos.Controllers
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCli(ModelCi cliente)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@cliname, @cliend, @clicpf, @clinum, @cliemail, @clinascdt)", con.ConectarBd());
            string data_sistema = Convert.ToDateTime(cliente.DtCliNasc).ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@cliname", MySqlDbType.VarChar).Value = cliente.CliName;
            cmd.Parameters.Add("@cliend", MySqlDbType.VarChar).Value = cliente.CliEnd;
            cmd.Parameters.Add("@clicpf", MySqlDbType.DateTime).Value = cliente.CliCpf;
            cmd.Parameters.Add("@clinum", MySqlDbType.VarChar).Value = cliente.CliNum;
            cmd.Parameters.Add("@cliemail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("@clinascdt", MySqlDbType.VarChar).Value = data_sistema;
            con.DesconectarBd();

        }

        public void CadastrarFunc(ModelFunc func)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values((@funcname, @funccargo, @funccod, @funcemail, @funcnum, @funcrg, @funccpf, @funcend, @funcnascdt)", con.ConectarBd());
            string data_sistema = Convert.ToDateTime(func.DtFuncNasc).ToString("yyyy-MM-dd");
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

        public void CadastrarGame(ModelGame jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values((@gamename, @gamegender, @gamedev, @gamecod, @gamelan, @gameversion, @gamesinopse, @gameplat, @gameidade)", con.ConectarBd());
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
    }
}