using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
    public class Chat
    {
        #region Fields
        private int idPelanggan;
        private int idDriver;
        private string chats;
        #endregion

        #region Constructors
        public Chat(int idPelanggan, int idDriver, string chats)
        {
            this.IdPelanggan = idPelanggan;
            this.IdDriver = idDriver;
            this.Chats = chats;
        }
        #endregion

        #region Properties
        public int IdPelanggan { get => idPelanggan; set => idPelanggan = value; }
        public int IdDriver { get => idDriver; set => idDriver = value; }
        public string Chats { get => chats; set => chats = value; }
        #endregion

        #region Methods
        #endregion
    }
}
