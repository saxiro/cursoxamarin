using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using App1_NossoChat.Model;
using Newtonsoft.Json;

namespace App1_NossoChat.Service
{
    public class ServiceWS
    {
        private static string EnderecoBase = "http://ws.spacedu.com.br/xf2018/rest/api";

        public static Usuario GetUsuario(Usuario usuario)
        {
            var URL = EnderecoBase + "/usuario";

            /*Maneira mais modesta de se montar o parâmentro
             * StringContent param = new StringContent(string.Format("?nome={0}&password={1}",usuario.Nome, usuario.Password) );
             */
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", usuario.Nome),
                new KeyValuePair<string,string>("password", usuario.Password)

            });


            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.PostAsync(URL, param).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return JsonConvert.DeserializeObject<Usuario>(content);
            }
            return null;
        }

        public static List<Chat> GetChats()
        {
            var URL = EnderecoBase + "/chats";

            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.GetAsync(URL).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content =
                response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (content.Length > 2)
                {
                    List<Chat> chats = JsonConvert.DeserializeObject<List<Chat>>(content);
                    return chats;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            return null;
        }

        public static bool InsertChat(Chat chat)
        {
            var URL = EnderecoBase + "/chat";

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", chat.Nome)
            });


            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.PostAsync(URL, param).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public static bool RenomearChat(Chat chat)
        {
            var URL = EnderecoBase + "/chat/" + chat.Id;

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", chat.Nome)
            });


            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.PutAsync(URL, param).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        public static bool DeleteChat(Chat chat)
        {
            var URL = EnderecoBase + "/chat/delete/" + chat.Id;

            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.DeleteAsync(URL).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        public static List<Mensagem> GetMensagensChat(Chat chat)
        {
            var URL = EnderecoBase + "/chat/" + chat.Id + "/msg";

            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.GetAsync(URL).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                if(content.Length > 2)
                {
                    return JsonConvert.DeserializeObject<List<Mensagem>>(content);
                }
            }

            return null;
        }

        public static bool InsertMensagem(Mensagem mensagem)
        {
            var URL = EnderecoBase + "/chat/" + mensagem.ChatID + "/msg";

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("mensagem", mensagem.mensagem),
                new KeyValuePair<string,string>("id_usuario", mensagem.UsuarioID.ToString())

            });


            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.PostAsync(URL, param).GetAwaiter().GetResult();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteMensagem(Mensagem mensagem)
        {
            var URL = EnderecoBase + "/chat/" + mensagem.ChatID + "/delete" + mensagem.Id;

            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.DeleteAsync(URL).GetAwaiter().GetResult();

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }
    }
}
