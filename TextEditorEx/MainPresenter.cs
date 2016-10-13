using System;
using TextEditorBL; 

namespace TextEditorEx
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly ITextEditor _manager;
        private readonly IMessage _messageService;

        public MainPresenter(IMainForm im, ITextEditor it, IMessage ime)
        {
            _view = im;
            _manager = it;
            _messageService = ime;
            _view.SetSymbolCount(0);
            _view.ContentChange += _view_ContentChange;
            _view.FIleOpenClick += _view_FIleOpenClick;
        }

        private void _view_FIleOpenClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_ContentChange(object sender, EventArgs e)
        {
            string content = _view.Content;
            int count = _manager.getSysmbolCount(content);
            _view.SetSymbolCount(count);
            
        }
    }
}
