using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateTest.BusinessLayer
{
    public class Project
    {
        private int _projectId;
        private string _projectName;
        private string _projectLink;
        private byte[] _previewImage;

        public int ProjectId { get => _projectId; set => _projectId = value; }
        public string ProjectName { get => _projectName; set => _projectName = value; }
        public string ProjectLink { get => _projectLink; set => _projectLink = value; }
        public byte[] PreviewImage { get => _previewImage; set => _previewImage = value; }

        public Project() { }

    }
}