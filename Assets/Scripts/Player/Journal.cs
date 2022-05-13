using System.Collections;
using System.Collections.Generic;

public class Journal
{
    private List<JournalItem> journalItems;

    public Journal()
    {
        journalItems = new List<JournalItem>();
    }

    public void AddJournalEntry(Dialog d)
    {
        if(!journalItems.Exists(jI => jI.Title.Equals(d.Title)))
        journalItems.Add(new JournalItem(d.Title, d.Description));
    }

    public List<JournalItem> ReturnAllEntries()
    {
        return journalItems;
    }
}
