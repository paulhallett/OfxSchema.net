// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxLanguageEnum
{
    // <xsd:simpleType name="LanguageEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The accepted values are based on the ISO-639 three-letter language codes.        The OFX element "LANGUAGEENUM" is of type "LanguageEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="AAR" />
    //         <xsd:enumeration value="ABK" />
    //         <xsd:enumeration value="ACE" />
    //         <xsd:enumeration value="ACH" />
    //         <xsd:enumeration value="ADA" />
    //         <xsd:enumeration value="AFA" />
    //         <xsd:enumeration value="AFH" />
    //         <xsd:enumeration value="AFR" />
    //         <xsd:enumeration value="AKA" />
    //         <xsd:enumeration value="AKK" />
    //         <xsd:enumeration value="ALB" />
    //         <xsd:enumeration value="ALE" />
    //         <xsd:enumeration value="ALG" />
    //         <xsd:enumeration value="AMH" />
    //         <xsd:enumeration value="ANG" />
    //         <xsd:enumeration value="APA" />
    //         <xsd:enumeration value="ARA" />
    //         <xsd:enumeration value="ARC" />
    //         <xsd:enumeration value="ARG" />
    //         <xsd:enumeration value="ARM" />
    //         <xsd:enumeration value="ARN" />
    //         <xsd:enumeration value="ARP" />
    //         <xsd:enumeration value="ART" />
    //         <xsd:enumeration value="ARW" />
    //         <xsd:enumeration value="ASM" />
    //         <xsd:enumeration value="AST" />
    //         <xsd:enumeration value="ATH" />
    //         <xsd:enumeration value="AUS" />
    //         <xsd:enumeration value="AVA" />
    //         <xsd:enumeration value="AVE" />
    //         <xsd:enumeration value="AWA" />
    //         <xsd:enumeration value="AYM" />
    //         <xsd:enumeration value="AZE" />
    //         <xsd:enumeration value="BAD" />
    //         <xsd:enumeration value="BAI" />
    //         <xsd:enumeration value="BAK" />
    //         <xsd:enumeration value="BAL" />
    //         <xsd:enumeration value="BAM" />
    //         <xsd:enumeration value="BAN" />
    //         <xsd:enumeration value="BAQ" />
    //         <xsd:enumeration value="BAS" />
    //         <xsd:enumeration value="BAT" />
    //         <xsd:enumeration value="BEJ" />
    //         <xsd:enumeration value="BEL" />
    //         <xsd:enumeration value="BEM" />
    //         <xsd:enumeration value="BEN" />
    //         <xsd:enumeration value="BER" />
    //         <xsd:enumeration value="BHO" />
    //         <xsd:enumeration value="BIH" />
    //         <xsd:enumeration value="BIK" />
    //         <xsd:enumeration value="BIN" />
    //         <xsd:enumeration value="BIS" />
    //         <xsd:enumeration value="BLA" />
    //         <xsd:enumeration value="BNT" />
    //         <xsd:enumeration value="BOS" />
    //         <xsd:enumeration value="BRA" />
    //         <xsd:enumeration value="BRE" />
    //         <xsd:enumeration value="BTK" />
    //         <xsd:enumeration value="BUA" />
    //         <xsd:enumeration value="BUG" />
    //         <xsd:enumeration value="BUL" />
    //         <xsd:enumeration value="BUR" />
    //         <xsd:enumeration value="CAD" />
    //         <xsd:enumeration value="CAI" />
    //         <xsd:enumeration value="CAR" />
    //         <xsd:enumeration value="CAT" />
    //         <xsd:enumeration value="CAU" />
    //         <xsd:enumeration value="CEB" />
    //         <xsd:enumeration value="CEL" />
    //         <xsd:enumeration value="CHA" />
    //         <xsd:enumeration value="CHB" />
    //         <xsd:enumeration value="CHE" />
    //         <xsd:enumeration value="CHG" />
    //         <xsd:enumeration value="CHI" />
    //         <xsd:enumeration value="CHK" />
    //         <xsd:enumeration value="CHM" />
    //         <xsd:enumeration value="CHN" />
    //         <xsd:enumeration value="CHO" />
    //         <xsd:enumeration value="CHP" />
    //         <xsd:enumeration value="CHR" />
    //         <xsd:enumeration value="CHU" />
    //         <xsd:enumeration value="CHV" />
    //         <xsd:enumeration value="CHY" />
    //         <xsd:enumeration value="CMC" />
    //         <xsd:enumeration value="COP" />
    //         <xsd:enumeration value="COR" />
    //         <xsd:enumeration value="COS" />
    //         <xsd:enumeration value="CPE" />
    //         <xsd:enumeration value="CPF" />
    //         <xsd:enumeration value="CPP" />
    //         <xsd:enumeration value="CRE" />
    //         <xsd:enumeration value="CRP" />
    //         <xsd:enumeration value="CUS" />
    //         <xsd:enumeration value="CZE" />
    //         <xsd:enumeration value="DAK" />
    //         <xsd:enumeration value="DAN" />
    //         <xsd:enumeration value="DAR" />
    //         <xsd:enumeration value="DAY" />
    //         <xsd:enumeration value="DEL" />
    //         <xsd:enumeration value="DEN" />
    //         <xsd:enumeration value="DGR" />
    //         <xsd:enumeration value="DIN" />
    //         <xsd:enumeration value="DIV" />
    //         <xsd:enumeration value="DOI" />
    //         <xsd:enumeration value="DRA" />
    //         <xsd:enumeration value="DUA" />
    //         <xsd:enumeration value="DUM" />
    //         <xsd:enumeration value="DUT" />
    //         <xsd:enumeration value="DYU" />
    //         <xsd:enumeration value="DZO" />
    //         <xsd:enumeration value="EFI" />
    //         <xsd:enumeration value="EGY" />
    //         <xsd:enumeration value="EKA" />
    //         <xsd:enumeration value="ELX" />
    //         <xsd:enumeration value="ENG" />
    //         <xsd:enumeration value="ENM" />
    //         <xsd:enumeration value="EPO" />
    //         <xsd:enumeration value="EST" />
    //         <xsd:enumeration value="EWE" />
    //         <xsd:enumeration value="EWO" />
    //         <xsd:enumeration value="FAN" />
    //         <xsd:enumeration value="FAO" />
    //         <xsd:enumeration value="FAT" />
    //         <xsd:enumeration value="FIJ" />
    //         <xsd:enumeration value="FIN" />
    //         <xsd:enumeration value="FIU" />
    //         <xsd:enumeration value="FON" />
    //         <xsd:enumeration value="FRE" />
    //         <xsd:enumeration value="FRM" />
    //         <xsd:enumeration value="FRO" />
    //         <xsd:enumeration value="FRY" />
    //         <xsd:enumeration value="FUL" />
    //         <xsd:enumeration value="FUR" />
    //         <xsd:enumeration value="GAA" />
    //         <xsd:enumeration value="GAY" />
    //         <xsd:enumeration value="GBA" />
    //         <xsd:enumeration value="GEM" />
    //         <xsd:enumeration value="GEO" />
    //         <xsd:enumeration value="GER" />
    //         <xsd:enumeration value="GEZ" />
    //         <xsd:enumeration value="GIL" />
    //         <xsd:enumeration value="GLA" />
    //         <xsd:enumeration value="GLE" />
    //         <xsd:enumeration value="GLG" />
    //         <xsd:enumeration value="GLV" />
    //         <xsd:enumeration value="GMH" />
    //         <xsd:enumeration value="GOH" />
    //         <xsd:enumeration value="GON" />
    //         <xsd:enumeration value="GOR" />
    //         <xsd:enumeration value="GOT" />
    //         <xsd:enumeration value="GRB" />
    //         <xsd:enumeration value="GRC" />
    //         <xsd:enumeration value="GRE" />
    //         <xsd:enumeration value="GRN" />
    //         <xsd:enumeration value="GUJ" />
    //         <xsd:enumeration value="GWI" />
    //         <xsd:enumeration value="HAI" />
    //         <xsd:enumeration value="HAU" />
    //         <xsd:enumeration value="HAW" />
    //         <xsd:enumeration value="HEB" />
    //         <xsd:enumeration value="HER" />
    //         <xsd:enumeration value="HIL" />
    //         <xsd:enumeration value="HIM" />
    //         <xsd:enumeration value="HIN" />
    //         <xsd:enumeration value="HIT" />
    //         <xsd:enumeration value="HMN" />
    //         <xsd:enumeration value="HMO" />
    //         <xsd:enumeration value="HUN" />
    //         <xsd:enumeration value="HUP" />
    //         <xsd:enumeration value="IBA" />
    //         <xsd:enumeration value="IBO" />
    //         <xsd:enumeration value="ICE" />
    //         <xsd:enumeration value="IDO" />
    //         <xsd:enumeration value="III" />
    //         <xsd:enumeration value="IJO" />
    //         <xsd:enumeration value="IKU" />
    //         <xsd:enumeration value="ILE" />
    //         <xsd:enumeration value="ILO" />
    //         <xsd:enumeration value="INA" />
    //         <xsd:enumeration value="INC" />
    //         <xsd:enumeration value="IND" />
    //         <xsd:enumeration value="INE" />
    //         <xsd:enumeration value="INH" />
    //         <xsd:enumeration value="IPK" />
    //         <xsd:enumeration value="IRA" />
    //         <xsd:enumeration value="IRO" />
    //         <xsd:enumeration value="ITA" />
    //         <xsd:enumeration value="JAV" />
    //         <xsd:enumeration value="JPN" />
    //         <xsd:enumeration value="JPR" />
    //         <xsd:enumeration value="JRB" />
    //         <xsd:enumeration value="KAA" />
    //         <xsd:enumeration value="KAB" />
    //         <xsd:enumeration value="KAC" />
    //         <xsd:enumeration value="KAL" />
    //         <xsd:enumeration value="KAM" />
    //         <xsd:enumeration value="KAN" />
    //         <xsd:enumeration value="KAR" />
    //         <xsd:enumeration value="KAS" />
    //         <xsd:enumeration value="KAU" />
    //         <xsd:enumeration value="KAW" />
    //         <xsd:enumeration value="KAZ" />
    //         <xsd:enumeration value="KBD" />
    //         <xsd:enumeration value="KHA" />
    //         <xsd:enumeration value="KHI" />
    //         <xsd:enumeration value="KHM" />
    //         <xsd:enumeration value="KHO" />
    //         <xsd:enumeration value="KIK" />
    //         <xsd:enumeration value="KIN" />
    //         <xsd:enumeration value="KIR" />
    //         <xsd:enumeration value="KMB" />
    //         <xsd:enumeration value="KOK" />
    //         <xsd:enumeration value="KOM" />
    //         <xsd:enumeration value="KON" />
    //         <xsd:enumeration value="KOR" />
    //         <xsd:enumeration value="KOS" />
    //         <xsd:enumeration value="KPE" />
    //         <xsd:enumeration value="KRO" />
    //         <xsd:enumeration value="KRU" />
    //         <xsd:enumeration value="KUA" />
    //         <xsd:enumeration value="KUM" />
    //         <xsd:enumeration value="KUR" />
    //         <xsd:enumeration value="KUT" />
    //         <xsd:enumeration value="LAD" />
    //         <xsd:enumeration value="LAH" />
    //         <xsd:enumeration value="LAM" />
    //         <xsd:enumeration value="LAO" />
    //         <xsd:enumeration value="LAT" />
    //         <xsd:enumeration value="LAV" />
    //         <xsd:enumeration value="LEZ" />
    //         <xsd:enumeration value="LIM" />
    //         <xsd:enumeration value="LIN" />
    //         <xsd:enumeration value="LIT" />
    //         <xsd:enumeration value="LOL" />
    //         <xsd:enumeration value="LOZ" />
    //         <xsd:enumeration value="LTZ" />
    //         <xsd:enumeration value="LUA" />
    //         <xsd:enumeration value="LUB" />
    //         <xsd:enumeration value="LUG" />
    //         <xsd:enumeration value="LUI" />
    //         <xsd:enumeration value="LUN" />
    //         <xsd:enumeration value="LUO" />
    //         <xsd:enumeration value="LUS" />
    //         <xsd:enumeration value="MAC" />
    //         <xsd:enumeration value="MAD" />
    //         <xsd:enumeration value="MAG" />
    //         <xsd:enumeration value="MAH" />
    //         <xsd:enumeration value="MAI" />
    //         <xsd:enumeration value="MAK" />
    //         <xsd:enumeration value="MAL" />
    //         <xsd:enumeration value="MAN" />
    //         <xsd:enumeration value="MAO" />
    //         <xsd:enumeration value="MAP" />
    //         <xsd:enumeration value="MAR" />
    //         <xsd:enumeration value="MAS" />
    //         <xsd:enumeration value="MAY" />
    //         <xsd:enumeration value="MDR" />
    //         <xsd:enumeration value="MEN" />
    //         <xsd:enumeration value="MGA" />
    //         <xsd:enumeration value="MIC" />
    //         <xsd:enumeration value="MIN" />
    //         <xsd:enumeration value="MIS" />
    //         <xsd:enumeration value="MKH" />
    //         <xsd:enumeration value="MLG" />
    //         <xsd:enumeration value="MLT" />
    //         <xsd:enumeration value="MNC" />
    //         <xsd:enumeration value="MNI" />
    //         <xsd:enumeration value="MNO" />
    //         <xsd:enumeration value="MOH" />
    //         <xsd:enumeration value="MOL" />
    //         <xsd:enumeration value="MON" />
    //         <xsd:enumeration value="MOS" />
    //         <xsd:enumeration value="MUL" />
    //         <xsd:enumeration value="MUN" />
    //         <xsd:enumeration value="MUS" />
    //         <xsd:enumeration value="MWR" />
    //         <xsd:enumeration value="MYN" />
    //         <xsd:enumeration value="NAH" />
    //         <xsd:enumeration value="NAI" />
    //         <xsd:enumeration value="NAP" />
    //         <xsd:enumeration value="NAU" />
    //         <xsd:enumeration value="NAV" />
    //         <xsd:enumeration value="NBL" />
    //         <xsd:enumeration value="NDE" />
    //         <xsd:enumeration value="NDO" />
    //         <xsd:enumeration value="NDS" />
    //         <xsd:enumeration value="NEP" />
    //         <xsd:enumeration value="NEW" />
    //         <xsd:enumeration value="NIA" />
    //         <xsd:enumeration value="NIC" />
    //         <xsd:enumeration value="NIU" />
    //         <xsd:enumeration value="NNO" />
    //         <xsd:enumeration value="NOB" />
    //         <xsd:enumeration value="NON" />
    //         <xsd:enumeration value="NOR" />
    //         <xsd:enumeration value="NSO" />
    //         <xsd:enumeration value="NUB" />
    //         <xsd:enumeration value="NYA" />
    //         <xsd:enumeration value="NYM" />
    //         <xsd:enumeration value="NYN" />
    //         <xsd:enumeration value="NYO" />
    //         <xsd:enumeration value="NZI" />
    //         <xsd:enumeration value="OCI" />
    //         <xsd:enumeration value="OJI" />
    //         <xsd:enumeration value="ORI" />
    //         <xsd:enumeration value="ORM" />
    //         <xsd:enumeration value="OSA" />
    //         <xsd:enumeration value="OSS" />
    //         <xsd:enumeration value="OTA" />
    //         <xsd:enumeration value="OTO" />
    //         <xsd:enumeration value="PAA" />
    //         <xsd:enumeration value="PAG" />
    //         <xsd:enumeration value="PAL" />
    //         <xsd:enumeration value="PAM" />
    //         <xsd:enumeration value="PAN" />
    //         <xsd:enumeration value="PAP" />
    //         <xsd:enumeration value="PAU" />
    //         <xsd:enumeration value="PEO" />
    //         <xsd:enumeration value="PER" />
    //         <xsd:enumeration value="PHI" />
    //         <xsd:enumeration value="PHN" />
    //         <xsd:enumeration value="PLI" />
    //         <xsd:enumeration value="POL" />
    //         <xsd:enumeration value="PON" />
    //         <xsd:enumeration value="POR" />
    //         <xsd:enumeration value="PRA" />
    //         <xsd:enumeration value="PRO" />
    //         <xsd:enumeration value="PUS" />
    //         <xsd:enumeration value="QAA" />
    //         <xsd:enumeration value="QUE" />
    //         <xsd:enumeration value="RAJ" />
    //         <xsd:enumeration value="RAP" />
    //         <xsd:enumeration value="RAR" />
    //         <xsd:enumeration value="ROA" />
    //         <xsd:enumeration value="ROH" />
    //         <xsd:enumeration value="ROM" />
    //         <xsd:enumeration value="RUM" />
    //         <xsd:enumeration value="RUN" />
    //         <xsd:enumeration value="RUS" />
    //         <xsd:enumeration value="SAD" />
    //         <xsd:enumeration value="SAG" />
    //         <xsd:enumeration value="SAH" />
    //         <xsd:enumeration value="SAI" />
    //         <xsd:enumeration value="SAL" />
    //         <xsd:enumeration value="SAM" />
    //         <xsd:enumeration value="SAN" />
    //         <xsd:enumeration value="SAS" />
    //         <xsd:enumeration value="SAT" />
    //         <xsd:enumeration value="SCC" />
    //         <xsd:enumeration value="SCO" />
    //         <xsd:enumeration value="SCR" />
    //         <xsd:enumeration value="SEL" />
    //         <xsd:enumeration value="SEM" />
    //         <xsd:enumeration value="SGA" />
    //         <xsd:enumeration value="SGN" />
    //         <xsd:enumeration value="SHN" />
    //         <xsd:enumeration value="SID" />
    //         <xsd:enumeration value="SIN" />
    //         <xsd:enumeration value="SIO" />
    //         <xsd:enumeration value="SIT" />
    //         <xsd:enumeration value="SLA" />
    //         <xsd:enumeration value="SLO" />
    //         <xsd:enumeration value="SLV" />
    //         <xsd:enumeration value="SMA" />
    //         <xsd:enumeration value="SME" />
    //         <xsd:enumeration value="SMI" />
    //         <xsd:enumeration value="SMJ" />
    //         <xsd:enumeration value="SMN" />
    //         <xsd:enumeration value="SMO" />
    //         <xsd:enumeration value="SMS" />
    //         <xsd:enumeration value="SNA" />
    //         <xsd:enumeration value="SND" />
    //         <xsd:enumeration value="SNK" />
    //         <xsd:enumeration value="SOG" />
    //         <xsd:enumeration value="SOM" />
    //         <xsd:enumeration value="SON" />
    //         <xsd:enumeration value="SOT" />
    //         <xsd:enumeration value="SPA" />
    //         <xsd:enumeration value="SRD" />
    //         <xsd:enumeration value="SRR" />
    //         <xsd:enumeration value="SSA" />
    //         <xsd:enumeration value="SSW" />
    //         <xsd:enumeration value="SUK" />
    //         <xsd:enumeration value="SUN" />
    //         <xsd:enumeration value="SUS" />
    //         <xsd:enumeration value="SUX" />
    //         <xsd:enumeration value="SWA" />
    //         <xsd:enumeration value="SWE" />
    //         <xsd:enumeration value="SYR" />
    //         <xsd:enumeration value="TAH" />
    //         <xsd:enumeration value="TAI" />
    //         <xsd:enumeration value="TAM" />
    //         <xsd:enumeration value="TAT" />
    //         <xsd:enumeration value="TEL" />
    //         <xsd:enumeration value="TEM" />
    //         <xsd:enumeration value="TER" />
    //         <xsd:enumeration value="TET" />
    //         <xsd:enumeration value="TGK" />
    //         <xsd:enumeration value="TGL" />
    //         <xsd:enumeration value="THA" />
    //         <xsd:enumeration value="TIB" />
    //         <xsd:enumeration value="TIG" />
    //         <xsd:enumeration value="TIR" />
    //         <xsd:enumeration value="TIV" />
    //         <xsd:enumeration value="TKL" />
    //         <xsd:enumeration value="TLI" />
    //         <xsd:enumeration value="TMH" />
    //         <xsd:enumeration value="TOG" />
    //         <xsd:enumeration value="TON" />
    //         <xsd:enumeration value="TPI" />
    //         <xsd:enumeration value="TSI" />
    //         <xsd:enumeration value="TSN" />
    //         <xsd:enumeration value="TSO" />
    //         <xsd:enumeration value="TUK" />
    //         <xsd:enumeration value="TUM" />
    //         <xsd:enumeration value="TUP" />
    //         <xsd:enumeration value="TUR" />
    //         <xsd:enumeration value="TUT" />
    //         <xsd:enumeration value="TVL" />
    //         <xsd:enumeration value="TWI" />
    //         <xsd:enumeration value="TYV" />
    //         <xsd:enumeration value="UGA" />
    //         <xsd:enumeration value="UIG" />
    //         <xsd:enumeration value="UKR" />
    //         <xsd:enumeration value="UMB" />
    //         <xsd:enumeration value="UND" />
    //         <xsd:enumeration value="URD" />
    //         <xsd:enumeration value="UZB" />
    //         <xsd:enumeration value="VAI" />
    //         <xsd:enumeration value="VEN" />
    //         <xsd:enumeration value="VIE" />
    //         <xsd:enumeration value="VOL" />
    //         <xsd:enumeration value="VOT" />
    //         <xsd:enumeration value="WAK" />
    //         <xsd:enumeration value="WAL" />
    //         <xsd:enumeration value="WAR" />
    //         <xsd:enumeration value="WAS" />
    //         <xsd:enumeration value="WEL" />
    //         <xsd:enumeration value="WEN" />
    //         <xsd:enumeration value="WLN" />
    //         <xsd:enumeration value="WOL" />
    //         <xsd:enumeration value="XHO" />
    //         <xsd:enumeration value="YAO" />
    //         <xsd:enumeration value="YAP" />
    //         <xsd:enumeration value="YID" />
    //         <xsd:enumeration value="YOR" />
    //         <xsd:enumeration value="YPK" />
    //         <xsd:enumeration value="ZAP" />
    //         <xsd:enumeration value="ZEN" />
    //         <xsd:enumeration value="ZHA" />
    //         <xsd:enumeration value="ZND" />
    //         <xsd:enumeration value="ZUL" />
    //         <xsd:enumeration value="ZUN" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    AAR,
    ABK,
    ACE,
    ACH,
    ADA,
    AFA,
    AFH,
    AFR,
    AKA,
    AKK,
    ALB,
    ALE,
    ALG,
    AMH,
    ANG,
    APA,
    ARA,
    ARC,
    ARG,
    ARM,
    ARN,
    ARP,
    ART,
    ARW,
    ASM,
    AST,
    ATH,
    AUS,
    AVA,
    AVE,
    AWA,
    AYM,
    AZE,
    BAD,
    BAI,
    BAK,
    BAL,
    BAM,
    BAN,
    BAQ,
    BAS,
    BAT,
    BEJ,
    BEL,
    BEM,
    BEN,
    BER,
    BHO,
    BIH,
    BIK,
    BIN,
    BIS,
    BLA,
    BNT,
    BOS,
    BRA,
    BRE,
    BTK,
    BUA,
    BUG,
    BUL,
    BUR,
    CAD,
    CAI,
    CAR,
    CAT,
    CAU,
    CEB,
    CEL,
    CHA,
    CHB,
    CHE,
    CHG,
    CHI,
    CHK,
    CHM,
    CHN,
    CHO,
    CHP,
    CHR,
    CHU,
    CHV,
    CHY,
    CMC,
    COP,
    COR,
    COS,
    CPE,
    CPF,
    CPP,
    CRE,
    CRP,
    CUS,
    CZE,
    DAK,
    DAN,
    DAR,
    DAY,
    DEL,
    DEN,
    DGR,
    DIN,
    DIV,
    DOI,
    DRA,
    DUA,
    DUM,
    DUT,
    DYU,
    DZO,
    EFI,
    EGY,
    EKA,
    ELX,
    ENG,
    ENM,
    EPO,
    EST,
    EWE,
    EWO,
    FAN,
    FAO,
    FAT,
    FIJ,
    FIN,
    FIU,
    FON,
    FRE,
    FRM,
    FRO,
    FRY,
    FUL,
    FUR,
    GAA,
    GAY,
    GBA,
    GEM,
    GEO,
    GER,
    GEZ,
    GIL,
    GLA,
    GLE,
    GLG,
    GLV,
    GMH,
    GOH,
    GON,
    GOR,
    GOT,
    GRB,
    GRC,
    GRE,
    GRN,
    GUJ,
    GWI,
    HAI,
    HAU,
    HAW,
    HEB,
    HER,
    HIL,
    HIM,
    HIN,
    HIT,
    HMN,
    HMO,
    HUN,
    HUP,
    IBA,
    IBO,
    ICE,
    IDO,
    III,
    IJO,
    IKU,
    ILE,
    ILO,
    INA,
    INC,
    IND,
    INE,
    INH,
    IPK,
    IRA,
    IRO,
    ITA,
    JAV,
    JPN,
    JPR,
    JRB,
    KAA,
    KAB,
    KAC,
    KAL,
    KAM,
    KAN,
    KAR,
    KAS,
    KAU,
    KAW,
    KAZ,
    KBD,
    KHA,
    KHI,
    KHM,
    KHO,
    KIK,
    KIN,
    KIR,
    KMB,
    KOK,
    KOM,
    KON,
    KOR,
    KOS,
    KPE,
    KRO,
    KRU,
    KUA,
    KUM,
    KUR,
    KUT,
    LAD,
    LAH,
    LAM,
    LAO,
    LAT,
    LAV,
    LEZ,
    LIM,
    LIN,
    LIT,
    LOL,
    LOZ,
    LTZ,
    LUA,
    LUB,
    LUG,
    LUI,
    LUN,
    LUO,
    LUS,
    MAC,
    MAD,
    MAG,
    MAH,
    MAI,
    MAK,
    MAL,
    MAN,
    MAO,
    MAP,
    MAR,
    MAS,
    MAY,
    MDR,
    MEN,
    MGA,
    MIC,
    MIN,
    MIS,
    MKH,
    MLG,
    MLT,
    MNC,
    MNI,
    MNO,
    MOH,
    MOL,
    MON,
    MOS,
    MUL,
    MUN,
    MUS,
    MWR,
    MYN,
    NAH,
    NAI,
    NAP,
    NAU,
    NAV,
    NBL,
    NDE,
    NDO,
    NDS,
    NEP,
    NEW,
    NIA,
    NIC,
    NIU,
    NNO,
    NOB,
    NON,
    NOR,
    NSO,
    NUB,
    NYA,
    NYM,
    NYN,
    NYO,
    NZI,
    OCI,
    OJI,
    ORI,
    ORM,
    OSA,
    OSS,
    OTA,
    OTO,
    PAA,
    PAG,
    PAL,
    PAM,
    PAN,
    PAP,
    PAU,
    PEO,
    PER,
    PHI,
    PHN,
    PLI,
    POL,
    PON,
    POR,
    PRA,
    PRO,
    PUS,
    QAA,
    QUE,
    RAJ,
    RAP,
    RAR,
    ROA,
    ROH,
    ROM,
    RUM,
    RUN,
    RUS,
    SAD,
    SAG,
    SAH,
    SAI,
    SAL,
    SAM,
    SAN,
    SAS,
    SAT,
    SCC,
    SCO,
    SCR,
    SEL,
    SEM,
    SGA,
    SGN,
    SHN,
    SID,
    SIN,
    SIO,
    SIT,
    SLA,
    SLO,
    SLV,
    SMA,
    SME,
    SMI,
    SMJ,
    SMN,
    SMO,
    SMS,
    SNA,
    SND,
    SNK,
    SOG,
    SOM,
    SON,
    SOT,
    SPA,
    SRD,
    SRR,
    SSA,
    SSW,
    SUK,
    SUN,
    SUS,
    SUX,
    SWA,
    SWE,
    SYR,
    TAH,
    TAI,
    TAM,
    TAT,
    TEL,
    TEM,
    TER,
    TET,
    TGK,
    TGL,
    THA,
    TIB,
    TIG,
    TIR,
    TIV,
    TKL,
    TLI,
    TMH,
    TOG,
    TON,
    TPI,
    TSI,
    TSN,
    TSO,
    TUK,
    TUM,
    TUP,
    TUR,
    TUT,
    TVL,
    TWI,
    TYV,
    UGA,
    UIG,
    UKR,
    UMB,
    UND,
    URD,
    UZB,
    VAI,
    VEN,
    VIE,
    VOL,
    VOT,
    WAK,
    WAL,
    WAR,
    WAS,
    WEL,
    WEN,
    WLN,
    WOL,
    XHO,
    YAO,
    YAP,
    YID,
    YOR,
    YPK,
    ZAP,
    ZEN,
    ZHA,
    ZND,
    ZUL,
    ZUN,
}
