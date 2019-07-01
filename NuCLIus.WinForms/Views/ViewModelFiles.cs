using NuCLIus.Core.Contracts;
using penCsharpener.DotnetUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Views {
    public class ViewModelFiles : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelFiles(IPreferenceService preferenceService,
                              IFileService fileService) {
            PreferenceService = preferenceService;
            FileService = fileService;
            BsFiles.DataSource = new List<IFile>();
            PropertyChanged += async (s, e) => {
                if (e.PropertyName == nameof(TextSearch)) {
                    await UpdateFilesData();
                }
            };
        }

        public IPreferenceService PreferenceService { get; }
        public IFileService FileService { get; }
        public BindingSource BsFiles { get; set; } = new BindingSource();
        public BindingSource BsMostFrequent { get; set; } = new BindingSource();
        public BindingSource BsNupkgLog { get; set; } = new BindingSource();

        #region Files

        public string TextSearch { get; set; }

        public async Task UpdateFilesData(bool updateView = true) {
            IEnumerable<IFile> files = new List<IFile>();
            await await Task.Factory.StartNew( async () => {
                files = await FileService.GetFiles();
                if (!string.IsNullOrWhiteSpace(TextSearch)) {
                    files = files.Where(x => x.Path.Like(TextSearch));
                }
            });
            BsFiles.DataSource = files.ToList();
        }

        public async Task RefreshFromFs() {
            await await Task.Factory.StartNew(async () => {
                await FileService.RefreshFromFileSystem();
            });
            await UpdateFilesData(false);
        }

        #endregion

        #region Nupkg

        #endregion

        #region Log

        #endregion
    }
}
