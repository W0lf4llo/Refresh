using System.Xml.Serialization;
using Realms;

namespace Refresh.GameServer.Types.Report;

[XmlRoot("slot")]
public class Slot : EmbeddedObject 
{ 
    [XmlElement("id")] 
    public int Id { get; set; } 

    [XmlAttribute("type")] 
    public string Type { get; set; } 

    [XmlText] 
    public string Text { get; set; } 

    [XmlElement("screenRect")] 
    public ScreenRect ScreenRect { get; set; } 

    [XmlElement("slotId")] 
    public string SlotId { get; set; } 

    [XmlElement("name")] 
    public string Name { get; set; } 

    [XmlElement("icon")] 
    public string Icon { get; set; } 
}