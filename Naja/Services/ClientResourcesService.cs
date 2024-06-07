using System.Xml.Linq;

namespace Naja.Services;

public interface IClientResourcesService
{
    string GetAttribute(string resource, ushort id, string attribute);
}

public class ClientResourcesService : IClientResourcesService
{
    private readonly XmlService _xmlService;
    private readonly XDocument _abilityRecastsDocument;
    private readonly XDocument _actionMessagesDocument;
    private readonly XDocument _augmentsDocument;
    private readonly XDocument _autoTranslatesDocument;
    private readonly XDocument _bagsDocument;
    private readonly XDocument _buffsDocument;
    private readonly XDocument _chatDocument;
    private readonly XDocument _checkRatingsDocument;
    private readonly XDocument _daysDocument;
    private readonly XDocument _elementsDocument;
    private readonly XDocument _emotesDocument;
    private readonly XDocument _encumbranceDocument;
    private readonly XDocument _itemsDocument;
    private readonly XDocument _itemsGrammarDocument;
    private readonly XDocument _itemDescriptionsDocument;
    private readonly XDocument _jobsDocument;
    private readonly XDocument _jobAbilitiesDocument;
    private readonly XDocument _jobPointsDocument;
    private readonly XDocument _jobTraitsDocument;
    private readonly XDocument _keyItemsDocument;
    private readonly XDocument _meritPointsDocument;
    private readonly XDocument _monsterAbilitiesDocument;
    private readonly XDocument _monsterSkillsDocument;
    private readonly XDocument _monstrosityDocument;
    private readonly XDocument _moonPhasesDocument;
    private readonly XDocument _mountsDocument;
    private readonly XDocument _racesDocument;
    private readonly XDocument _regionsDocument;
    private readonly XDocument _serversDocument;
    private readonly XDocument _skillsDocument;
    private readonly XDocument _slotsDocument;
    private readonly XDocument _spellsDocument;
    private readonly XDocument _statusesDocument;
    private readonly XDocument _synthRanksDocument;
    private readonly XDocument _titlesDocument;
    private readonly XDocument _weaponSkillsDocument;
    private readonly XDocument _weatherDocument;
    private readonly XDocument _zonesDocument;

    public ClientResourcesService(XmlService xmlService)
    {
        _xmlService = xmlService;
        _abilityRecastsDocument = _xmlService.LoadXml("../Resources/ability_recasts.xml");
        _actionMessagesDocument = _xmlService.LoadXml("../Resources/action_messages.xml");
        _augmentsDocument = _xmlService.LoadXml("../Resources/augments.xml");
        _autoTranslatesDocument = _xmlService.LoadXml("../Resources/auto_translates.xml");
        _bagsDocument = _xmlService.LoadXml("../Resources/bags.xml");
        _buffsDocument = _xmlService.LoadXml("../Resources/buffs.xml");
        _chatDocument = _xmlService.LoadXml("../Resources/chat.xml");
        _checkRatingsDocument = _xmlService.LoadXml("../Resources/check_ratings.xml");
        _daysDocument = _xmlService.LoadXml("../Resources/days.xml");
        _elementsDocument = _xmlService.LoadXml("../Resources/elements.xml");
        _emotesDocument = _xmlService.LoadXml("../Resources/emotes.xml");
        _encumbranceDocument = _xmlService.LoadXml("../Resources/encumbrance.xml");
        _itemsDocument = _xmlService.LoadXml("../Resources/items.xml");
        _itemsGrammarDocument = _xmlService.LoadXml("../Resources/items_grammar.xml");
        _itemDescriptionsDocument = _xmlService.LoadXml("../Resources/item_descriptions.xml");
        _jobsDocument = _xmlService.LoadXml("../Resources/jobs.xml");
        _jobAbilitiesDocument = _xmlService.LoadXml("../Resources/job_abilities.xml");
        _jobPointsDocument = _xmlService.LoadXml("../Resources/job_points.xml");
        _jobTraitsDocument = _xmlService.LoadXml("../Resources/job_traits.xml");
        _keyItemsDocument = _xmlService.LoadXml("../Resources/key_items.xml");
        _meritPointsDocument = _xmlService.LoadXml("../Resources/merit_points.xml");
        _monsterAbilitiesDocument = _xmlService.LoadXml("../Resources/monster_abilities.xml");
        _monsterSkillsDocument = _xmlService.LoadXml("../Resources/monster_skills.xml");
        _monstrosityDocument = _xmlService.LoadXml("../Resources/monstrosity.xml");
        _moonPhasesDocument = _xmlService.LoadXml("../Resources/moon_phases.xml");
        _mountsDocument = _xmlService.LoadXml("../Resources/mounts.xml");
        _racesDocument = _xmlService.LoadXml("../Resources/races.xml");
        _regionsDocument = _xmlService.LoadXml("../Resources/regions.xml");
        _serversDocument = _xmlService.LoadXml("../Resources/servers.xml");
        _skillsDocument = _xmlService.LoadXml("../Resources/skills.xml");
        _slotsDocument = _xmlService.LoadXml("../Resources/slots.xml");
        _spellsDocument = _xmlService.LoadXml("../Resources/spells.xml");
        _statusesDocument = _xmlService.LoadXml("../Resources/statuses.xml");
        _synthRanksDocument = _xmlService.LoadXml("../Resources/synth_ranks.xml");
        _titlesDocument = _xmlService.LoadXml("../Resources/titles.xml");
        _weaponSkillsDocument = _xmlService.LoadXml("../Resources/weapon_skills.xml");
        _weatherDocument = _xmlService.LoadXml("../Resources/weather.xml");
        _zonesDocument = _xmlService.LoadXml("../Resources/zones.xml");
    }

    public string GetAttribute(string resource, ushort id, string attribute)
    {
        XElement? element;
        switch (resource)
        {
            case "ability_recasts":
                element = _xmlService.GetElementById(_abilityRecastsDocument, "o", "id", id);
                break;
            case "action_messages":
                element = _xmlService.GetElementById(_actionMessagesDocument, "o", "id", id);
                break;
            case "augments":
                element = _xmlService.GetElementById(_augmentsDocument, "o", "id", id);
                break;
            case "auto_translates":
                element = _xmlService.GetElementById(_autoTranslatesDocument, "o", "id", id);
                break;
            case "bags":
                element = _xmlService.GetElementById(_bagsDocument, "o", "id", id);
                break;
            case "buffs":
                element = _xmlService.GetElementById(_buffsDocument, "o", "id", id);
                break;
            case "chat":
                element = _xmlService.GetElementById(_chatDocument, "o", "id", id);
                break;
            case "check_ratings":
                element = _xmlService.GetElementById(_checkRatingsDocument, "o", "id", id);
                break;
            case "days":
                element = _xmlService.GetElementById(_daysDocument, "o", "id", id);
                break;
            case "elements":
                element = _xmlService.GetElementById(_elementsDocument, "o", "id", id);
                break;
            case "emotes":
                element = _xmlService.GetElementById(_emotesDocument, "o", "id", id);
                break;
            case "encumbrance":
                element = _xmlService.GetElementById(_encumbranceDocument, "o", "id", id);
                break;
            case "items":
                element = _xmlService.GetElementById(_itemsDocument, "o", "id", id);
                break;
            case "items_grammar":
                element = _xmlService.GetElementById(_itemsGrammarDocument, "o", "id", id);
                break;
            case "item_descriptions":
                element = _xmlService.GetElementById(_itemDescriptionsDocument, "o", "id", id);
                break;
            case "jobs":
                element = _xmlService.GetElementById(_jobsDocument, "o", "id", id);
                break;
            case "job_abilities":
                element = _xmlService.GetElementById(_jobAbilitiesDocument, "o", "id", id);
                break;
            case "job_points":
                element = _xmlService.GetElementById(_jobPointsDocument, "o", "id", id);
                break;
            case "job_traits":
                element = _xmlService.GetElementById(_jobTraitsDocument, "o", "id", id);
                break;
            case "key_items":
                element = _xmlService.GetElementById(_keyItemsDocument, "o", "id", id);
                break;
            case "merit_points":
                element = _xmlService.GetElementById(_meritPointsDocument, "o", "id", id);
                break;
            case "monster_abilities":
                element = _xmlService.GetElementById(_monsterAbilitiesDocument, "o", "id", id);
                break;
            case "monster_skills":
                element = _xmlService.GetElementById(_monsterSkillsDocument, "o", "id", id);
                break;
            case "monstrosity":
                element = _xmlService.GetElementById(_monstrosityDocument, "o", "id", id);
                break;
            case "moon_phases":
                element = _xmlService.GetElementById(_moonPhasesDocument, "o", "id", id);
                break;
            case "mounts":
                element = _xmlService.GetElementById(_mountsDocument, "o", "id", id);
                break;
            case "races":
                element = _xmlService.GetElementById(_racesDocument, "o", "id", id);
                break;
            case "regions":
                element = _xmlService.GetElementById(_regionsDocument, "o", "id", id);
                break;
            case "servers":
                element = _xmlService.GetElementById(_serversDocument, "o", "id", id);
                break;
            case "skills":
                element = _xmlService.GetElementById(_skillsDocument, "o", "id", id);
                break;
            case "slots":
                element = _xmlService.GetElementById(_slotsDocument, "o", "id", id);
                break;
            case "spells":
                element = _xmlService.GetElementById(_spellsDocument, "o", "id", id);
                break;
            case "statuses":
                element = _xmlService.GetElementById(_statusesDocument, "o", "id", id);
                break;
            case "synth_ranks":
                element = _xmlService.GetElementById(_synthRanksDocument, "o", "id", id);
                break;
            case "titles":
                element = _xmlService.GetElementById(_titlesDocument, "o", "id", id);
                break;
            case "weapon_skills":
                element = _xmlService.GetElementById(_weaponSkillsDocument, "o", "id", id);
                break;
            case "weather":
                element = _xmlService.GetElementById(_weatherDocument, "o", "id", id);
                break;
            case "zones":
                element = _xmlService.GetElementById(_zonesDocument, "o", "id", id);
                break;
            default:
                return "";
        }

        return _xmlService.GetAttributeValue(element, attribute);
    }
}
