using System.Collections.Generic;

using Conf = Sparkle.Configuration.Facade;

namespace Sparkle.Student.Facade.PersonalInformation.Guardian
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Conf.Relationship.Dto> RelationshipList { get; set; }

    }

}