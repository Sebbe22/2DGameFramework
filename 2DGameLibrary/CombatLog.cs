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
        /// <summary>
        /// making the singleton design pattern
        /// </summary>
        private static CombatLog _instance = new CombatLog();
        public static CombatLog Instance => _instance;

        /// <summary>
        /// private constructor so only the class itself can make an object
        /// </summary>
        private CombatLog() 
        {
            ts.Switch = new SourceSwitch("CombatLog", "Information");
            ts.Listeners.Add(FileListener);
            ts.Listeners.Add(XmlListener);
            ts.Flush();
        }
        TraceSource ts = new TraceSource("seb");

        TraceListener FileListener = new TextWriterTraceListener(new StreamWriter("CombatLog.txt"));
        TraceListener XmlListener = new XmlWriterTraceListener(new StreamWriter("CombatLog.xml"));

        /// <summary>
        /// method for logging attacks in combat
        /// </summary>
        /// <param name="target">the reciever of the attack</param>
        /// <param name="name">name of the attacker</param>
        /// <param name="hit">amount of damage delt</param>
        public void LogCombatAttack(Creature target, string name, int hit)
        {
            ts.TraceEvent(TraceEventType.Information, 1, $"{name} has hit {target.Name} for {hit} damage");
            ts.Flush();
        }

        /// <summary>
        /// method for logging damage taken
        /// </summary>
        /// <param name="name">name of the damage reciever</param>
        /// <param name="hit">amount of damage taken</param>
        public void LogCombatDefense(string name, int hit)
        {
            ts.TraceEvent(TraceEventType.Information, 1, $"{name} has taken {hit} damege!");
            ts.Flush();
        }
    }
}
