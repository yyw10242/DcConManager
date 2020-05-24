using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DcConManager.Pages
{
    public class QuickstartManager
    {
        public List<Page> Pages;

        private Page _quickstartPage1;
        public Page QuickstartPage1 => this._quickstartPage1 ?? (this._quickstartPage1 = new QuickstartPage1());

        private Page _quickstartPage2;
        public Page QuickstartPage2 => this._quickstartPage2 ?? (this._quickstartPage2 = new QuickstartPage2());

        private Page _quickstartPage3;
        public Page QuickstartPage3 => this._quickstartPage3 ?? (this._quickstartPage3 = new QuickstartPage3());

        private Page _quickstartPage4;
        public Page QuickstartPage4 => this._quickstartPage4 ?? (this._quickstartPage4 = new QuickstartPage4());

        private Frame Frame => Core.MainWindow.QuickstartFrame;

        private int _index;
        public int Index
        {
            get => this._index;
            set
            {
                int token = Math.Min(Math.Max(0, value), this.Pages.Count - 1);

                if (this._index == token) return;

                this.Frame.Content = this.Pages[token];

                this._index = token;
            }
        }

        public QuickstartManager()
        {
            this.Pages = new List<Page>()
            {
                this.QuickstartPage1,
                this.QuickstartPage2,
                this.QuickstartPage3,
                this.QuickstartPage4,
            };

            this._index = 0;
            this.Frame.Content = this.Pages.First();
        }

        public bool GoPrev()
        {
            this.Index--;

            return true;
        }

        public bool GoNext()
        {
            this.Index++;

            return true;
        }

        public void Reset()
        {
            this._index = 0;
            this.Frame.Content = this.Pages.First();
        }
    }
}
