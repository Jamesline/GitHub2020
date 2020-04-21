using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDogAdmin.State
{
    public class AppState
    {
        public string SelectedId { get; private set; }

        public event Action OnChange;

        public void SetSelectedId(string id)
        {
            SelectedId = id;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
