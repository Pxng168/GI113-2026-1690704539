/*
 * Student ID : 1690704539
 * Name       : Assignment01
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using System.Threading;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "JAVA SMASH";

            string entityName = "NECRO-LEVIATHAN OMEGA";
            char entityRank = 'S';
            int baseHealth = 8500000;
            float moveSpeed = 35.75f;
            double neuralSync = 99.9;
            bool isInfected = true;

            var entityId = "SUBJECT_ZERO";
            var threatLevel = 'X';

            double doubleHealth = baseHealth;

            int truncatedSync = (int)neuralSync;
            int roundedSync = Convert.ToInt32(neuralSync);

            Console.WriteLine($"    ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"    ║ ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████ ║");
            Console.WriteLine($"    ║ ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██ ║");
            Console.WriteLine($"    ║ ██░░    ██╗ █████╗ ██████╗  ██████╗ ███████╗████████╗    ██╗  ██╗██╗   ██╗██████╗       █████╗ ██████╗ ██╗██╗     ░░██ ║");
            Console.WriteLine($"    ║ ██░░    ██║██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝    ██║  ██║██║   ██║██╔══██╗      ██╔══██╗██╔══██╗██║██║     ░░██ ║");
            Console.WriteLine($"    ║ ██░░    ██║███████║██████╔╝██║  ██║█████╗     ██║       ███████║██║   ██║██║  ██║█████╗███████║██████╔╝██║██║     ░░██ ║");
            Console.WriteLine($"    ║ ██░░    ██║██╔══██║██╔══██║██║  ██║██╔══╝     ██║       ██╔══██║██║   ██║██║  ██║╚════╝██╔══██║██╔═══╝ ██║██║     ░░██ ║");
            Console.WriteLine($"    ║ ██░░    ██║██║  ██║██████╔╝██████╔╝███████╗   ██║       ██║  ██║╚██████╔╝██████╔╝      ██║  ██║██║     ██║██║     ░░██ ║");
            Console.WriteLine($"    ║ ██░░    ╚═╝╚═╝  ╚═╝╚═════╝ ╚═════╝ ╚══════╝   ╚═╝       ╚═╝  ╚═╝ ╚═════╝ ╚═════╝       ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝     ░░██ ║");
            Console.WriteLine($"    ║ ██░░                                                                                                              ░░██ ║");
            Console.WriteLine($"    ║ ██░░  ██████████████████████████████████████████████████████████████████████████████████████████████████████████  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  █ [!] PROJECT OVERRIDE: {GameTitle,-55} DATABASE VERSION: 9.9.99 █  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  ██████████████████████████████████████████████████████████████████████████████████████████████████████████  ░░██ ║");
            Console.WriteLine($"    ║ ██░░                                                                                                              ░░██ ║");
            Console.WriteLine($"    ║ ██░░  +=============================================+==========================================================+  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |  [ BIOMETRIC SCAN RENDER ]                  |  [ PRIMARY IDENTIFICATION & CLASSIFICATION ]             |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |                                             |                                                          |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |                 _,.-------.,_               |  >> ENTITY DESIGNATION : {entityName,-32}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |             ,;~'             '~;,           |  >> IDENTIFICATION CODE: {entityId,-32}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |           ,;                     ;,         |  >> BIOLOGICAL RANK    : CLASS {entityRank,-26}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |          ;    ,                   ;         |  >> GLOBAL THREAT LEVEL: CATEGORY {threatLevel,-23}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |         '   ,' \\_           _  \\   '        |  >> VIRAL INFECTION    : {isInfected,-32}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |        ;  (   \\ \\         / /  )  ;         |  >> MOVEMENT VELOCITY  : {moveSpeed,-28} M/S|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |        ;  ;\\   ` `       ' '  /;  ;         |                                                          |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |        ;  ; \\_   _       _   _/ ; ;         +==========================================================+  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |        '  ;   ```         ```   ; '         |  [ STRUCTURAL INTEGRITY & CAPACITY ]                     |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |         ;  \\     \\_\\_/_/     /  ;           |                                                          |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |          ', \\     '==='     / ,'            |  >> BASE HEALTH CAPITY : {baseHealth,-32}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |            ',_`~._______.~`_,'              |  >> IMPLICIT DOUBLE HP : {doubleHealth,-32}|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |               `'-------'`                   |  [██████████████████████████████████████████████░░░░░]   |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |                                             |                                                          |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |  [ WARNING ] MUTATION DETECTED              +==========================================================+  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |  [ DANGER  ] LETHAL FORCE REQUIRED          |  [ NEURAL DIAGNOSTIC & CORE PROCESSING LINK ]            |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |                                             |                                                          |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |  >>> SUB-SYSTEM DIAGNOSTICS:                |  >> RAW SYNC VALUE     : {neuralSync,-30} %|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |      CORTEX : ANOMALY FOUND                 |  >> EXPLICIT CAST (INT): {truncatedSync,-30} %|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |      TISSUE : REGENERATING                  |  >> CONVERT.TOINT32    : {roundedSync,-30} %|  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  |      HEART  : CORRUPTED                     |  [||||||||||||||||||||||||||||||||||||||||||||||||||||]  |  ░░██ ║");
            Console.WriteLine($"    ║ ██░░  +=============================================+==========================================================+  ░░██ ║");
            Console.WriteLine($"    ║ ██░░                                                                                                              ░░██ ║");
            Console.WriteLine($"    ║ ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██ ║");
            Console.WriteLine($"    ║ ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████ ║");
            Console.WriteLine($"    ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}