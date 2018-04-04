﻿using System.Collections.Generic;

namespace GitLab.VisualStudio.Shared
{
    public interface IGitService
    {
        string GetRemote(string path);

        IReadOnlyList<string> GetGitIgnores();

        IReadOnlyList<string> GetLicenses();

        void FillAccessories(string fullname, string email, string path, string gitignore, string license);

        void PushInitialCommit(string fullname, string email, string username, string password, string url, string gitignore, string license);

        void PushWithLicense(string fullname, string email, string username, string password, string url, string path, string license);
    }
}