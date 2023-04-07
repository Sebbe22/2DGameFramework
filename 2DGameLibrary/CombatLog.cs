using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2DGameLibrary
{
    class CombatLog
    {
        private static CombatLog _instance = new CombatLog();
        public static CombatLog Instance => _instance;
        private CombatLog() 
        {
            ts.Switch = new SourceSwitch("CombatLog", "Information");
            ts.Listeners.Add(FileListener);
            ts.Flush();
        }
        TraceSource ts = new TraceSource("seb");

        TraceListener FileListener = new TextWriterTraceListener(new StreamWriter("CombatLog.txt"));

        public void LogCombatAttack(Creature target, string name, int hit)
        {
            ts.TraceEvent(TraceEventType.Information, 1, $"{name} has hit {target.Name} for {hit} damage");
            ts.Flush();
        }

        public void LogCombatDefense(string name, int hit)
        {
            ts.TraceEvent(TraceEventType.Information, 1, $"{name} has taken {hit} damege!");
            ts.Flush();
        }
    }
}
