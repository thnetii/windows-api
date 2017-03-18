using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>Values for <var>ParmError</var> parameter to <see cref="NetServerSetInfo"/>.</summary>
    public enum SERVER_INFO_PARMNUM : int
    {
        /// <summary><var>sv*_platform_id</var></summary>
        SV_PLATFORM_ID_PARMNUM = 101,
        /// <summary><var>sv*_name</var></summary>
        SV_NAME_PARMNUM = 102,
        /// <summary><var>sv*_version_major</var></summary>
        SV_VERSION_MAJOR_PARMNUM = 103,
        /// <summary><var>sv*_version_minor</var></summary>
        SV_VERSION_MINOR_PARMNUM = 104,
        /// <summary><var>sv*_type</var></summary>
        SV_TYPE_PARMNUM = 105,
        /// <summary><var>sv*_comment</var></summary>
        SV_COMMENT_PARMNUM = 5,
        /// <summary><var>sv*_users</var></summary>
        SV_USERS_PARMNUM = 107,
        /// <summary><var>sv*_disc</var></summary>
        SV_DISC_PARMNUM = 10,
        /// <summary><var>sv*_hidden</var></summary>
        SV_HIDDEN_PARMNUM = 16,
        /// <summary><var>sv*_announce</var></summary>
        SV_ANNOUNCE_PARMNUM = 17,
        /// <summary><var>sv*_anndelta</var></summary>
        SV_ANNDELTA_PARMNUM = 18,
        /// <summary><var>sv*_userpath</var></summary>
        SV_USERPATH_PARMNUM = 112,

        /// <summary><var>sv*_ulist_mtime</var></summary>
        SV_ULIST_MTIME_PARMNUM = 401,
        /// <summary><var>sv*_glist_mtime</var></summary>
        SV_GLIST_MTIME_PARMNUM = 402,
        /// <summary><var>sv*_alist_mtime</var></summary>
        SV_ALIST_MTIME_PARMNUM = 403,
        /// <summary><var>sv*_alerts</var></summary>
        SV_ALERTS_PARMNUM = 11,
        /// <summary><var>sv*_security</var></summary>
        SV_SECURITY_PARMNUM = 405,
        /// <summary><var>sv*_numadmin</var></summary>
        SV_NUMADMIN_PARMNUM = 406,
        /// <summary><var>sv*_lanmask</var></summary>
        SV_LANMASK_PARMNUM = 407,
        /// <summary><var>sv*_guestacc</var></summary>
        SV_GUESTACC_PARMNUM = 408,
        /// <summary><var>sv*_chdevq</var></summary>
        SV_CHDEVQ_PARMNUM = 410,
        /// <summary><var>sv*_chdevjobs</var></summary>
        SV_CHDEVJOBS_PARMNUM = 411,
        /// <summary><var>sv*_connections</var></summary>
        SV_CONNECTIONS_PARMNUM = 412,
        /// <summary><var>sv*_shares</var></summary>
        SV_SHARES_PARMNUM = 413,
        /// <summary><var>sv*_openfiles</var></summary>
        SV_OPENFILES_PARMNUM = 414,
        /// <summary><var>sv*_sessreqs</var></summary>
        SV_SESSREQS_PARMNUM = 417,
        /// <summary><var>sv*_activelocks</var></summary>
        SV_ACTIVELOCKS_PARMNUM = 419,
        /// <summary><var>sv*_numreqbuf</var></summary>
        SV_NUMREQBUF_PARMNUM = 420,
        /// <summary><var>sv*_numbigbuf</var></summary>
        SV_NUMBIGBUF_PARMNUM = 422,
        /// <summary><var>sv*_numfiletasks</var></summary>
        SV_NUMFILETASKS_PARMNUM = 423,
        /// <summary><var>sv*_alertsched</var></summary>
        SV_ALERTSCHED_PARMNUM = 37,
        /// <summary><var>sv*_erroralert</var></summary>
        SV_ERRORALERT_PARMNUM = 38,
        /// <summary><var>sv*_logonalert</var></summary>
        SV_LOGONALERT_PARMNUM = 39,
        /// <summary><var>sv*_accessalert</var></summary>
        SV_ACCESSALERT_PARMNUM = 40,
        /// <summary><var>sv*_diskalert</var></summary>
        SV_DISKALERT_PARMNUM = 41,
        /// <summary><var>sv*_netioalert</var></summary>
        SV_NETIOALERT_PARMNUM = 42,
        /// <summary><var>sv*_maxauditsz</var></summary>
        SV_MAXAUDITSZ_PARMNUM = 43,
        /// <summary><var>sv*_srvheuristics</var></summary>
        SV_SRVHEURISTICS_PARMNUM = 431,

        /// <summary><var>sv*_sessopens</var></summary>
        SV_SESSOPENS_PARMNUM = 501,
        /// <summary><var>sv*_sessvcs</var></summary>
        SV_SESSVCS_PARMNUM = 502,
        /// <summary><var>sv*_opensearch</var></summary>
        SV_OPENSEARCH_PARMNUM = 503,
        /// <summary><var>sv*_sizreqbuf</var></summary>
        SV_SIZREQBUF_PARMNUM = 504,
        /// <summary><var>sv*_initworkitems</var></summary>
        SV_INITWORKITEMS_PARMNUM = 505,
        /// <summary><var>sv*_maxworkitems</var></summary>
        SV_MAXWORKITEMS_PARMNUM = 506,
        /// <summary><var>sv*_rawworkitems</var></summary>
        SV_RAWWORKITEMS_PARMNUM = 507,
        /// <summary><var>sv*_irpstacksize</var></summary>
        SV_IRPSTACKSIZE_PARMNUM = 508,
        /// <summary><var>sv*_maxrawbuflen</var></summary>
        SV_MAXRAWBUFLEN_PARMNUM = 509,
        /// <summary><var>sv*_sessusers</var></summary>
        SV_SESSUSERS_PARMNUM = 510,
        /// <summary><var>sv*_sessconns</var></summary>
        SV_SESSCONNS_PARMNUM = 511,
        /// <summary><var>sv*_maxnonpagedmemoryusage</var></summary>
        SV_MAXNONPAGEDMEMORYUSAGE_PARMNUM = 512,
        /// <summary><var>sv*_maxpagedmemoryusage</var></summary>
        SV_MAXPAGEDMEMORYUSAGE_PARMNUM = 513,
        /// <summary><var>sv*_enablesoftcompat</var></summary>
        SV_ENABLESOFTCOMPAT_PARMNUM = 514,
        /// <summary><var>sv*_enableforcedlogoff</var></summary>
        SV_ENABLEFORCEDLOGOFF_PARMNUM = 515,
        /// <summary><var>sv*_timesource</var></summary>
        SV_TIMESOURCE_PARMNUM = 516,
        /// <summary><var>sv*_acceptdownlevelapis</var></summary>
        SV_ACCEPTDOWNLEVELAPIS_PARMNUM = 517,
        /// <summary><var>sv*_lmannounce</var></summary>
        SV_LMANNOUNCE_PARMNUM = 518,
        /// <summary><var>sv*_domain</var></summary>
        SV_DOMAIN_PARMNUM = 519,
        /// <summary><var>sv*_maxcopyreadlen</var></summary>
        SV_MAXCOPYREADLEN_PARMNUM = 520,
        /// <summary><var>sv*_maxcopywritelen</var></summary>
        SV_MAXCOPYWRITELEN_PARMNUM = 521,
        /// <summary><var>sv*_minkeepsearch</var></summary>
        SV_MINKEEPSEARCH_PARMNUM = 522,
        /// <summary><var>sv*_maxkeepsearch</var></summary>
        SV_MAXKEEPSEARCH_PARMNUM = 523,
        /// <summary><var>sv*_minkeepcomplsearch</var></summary>
        SV_MINKEEPCOMPLSEARCH_PARMNUM = 524,
        /// <summary><var>sv*_maxkeepcomplsearch</var></summary>
        SV_MAXKEEPCOMPLSEARCH_PARMNUM = 525,
        /// <summary><var>sv*_threadcountadd</var></summary>
        SV_THREADCOUNTADD_PARMNUM = 526,
        /// <summary><var>sv*_numblockthreads</var></summary>
        SV_NUMBLOCKTHREADS_PARMNUM = 527,
        /// <summary><var>sv*_scavtimeout</var></summary>
        SV_SCAVTIMEOUT_PARMNUM = 528,
        /// <summary><var>sv*_minrcvqueue</var></summary>
        SV_MINRCVQUEUE_PARMNUM = 529,
        /// <summary><var>sv*_minfreeworkitems</var></summary>
        SV_MINFREEWORKITEMS_PARMNUM = 530,
        /// <summary><var>sv*_xactmemsize</var></summary>
        SV_XACTMEMSIZE_PARMNUM = 531,
        /// <summary><var>sv*_threadpriority</var></summary>
        SV_THREADPRIORITY_PARMNUM = 532,
        /// <summary><var>sv*_maxmpxct</var></summary>
        SV_MAXMPXCT_PARMNUM = 533,
        /// <summary><var>sv*_oplockbreakwait</var></summary>
        SV_OPLOCKBREAKWAIT_PARMNUM = 534,
        /// <summary><var>sv*_oplockbreakresponsewait</var></summary>
        SV_OPLOCKBREAKRESPONSEWAIT_PARMNUM = 535,
        /// <summary><var>sv*_enableoplocks</var></summary>
        SV_ENABLEOPLOCKS_PARMNUM = 536,
        /// <summary><var>sv*_enableoplockforceclose</var></summary>
        SV_ENABLEOPLOCKFORCECLOSE_PARMNUM = 537,
        /// <summary><var>sv*_enablefcbopens</var></summary>
        SV_ENABLEFCBOPENS_PARMNUM = 538,
        /// <summary><var>sv*_enableraw</var></summary>
        SV_ENABLERAW_PARMNUM = 539,
        /// <summary><var>sv*_enablesharednetdrives</var></summary>
        SV_ENABLESHAREDNETDRIVES_PARMNUM = 540,
        /// <summary><var>sv*_minfreeconnections</var></summary>
        SV_MINFREECONNECTIONS_PARMNUM = 541,
        /// <summary><var>sv*_maxfreeconnections</var></summary>
        SV_MAXFREECONNECTIONS_PARMNUM = 542,
        /// <summary><var>sv*_initsesstable</var></summary>
        SV_INITSESSTABLE_PARMNUM = 543,
        /// <summary><var>sv*_initconntable</var></summary>
        SV_INITCONNTABLE_PARMNUM = 544,
        /// <summary><var>sv*_initfiletable</var></summary>
        SV_INITFILETABLE_PARMNUM = 545,
        /// <summary><var>sv*_initsearchtable</var></summary>
        SV_INITSEARCHTABLE_PARMNUM = 546,
        /// <summary><var>sv*_alertschedule</var></summary>
        SV_ALERTSCHEDULE_PARMNUM = 547,
        /// <summary><var>sv*_errorthreshold</var></summary>
        SV_ERRORTHRESHOLD_PARMNUM = 548,
        /// <summary><var>sv*_networkerrorthreshold</var></summary>
        SV_NETWORKERRORTHRESHOLD_PARMNUM = 549,
        /// <summary><var>sv*_diskspacethreshold</var></summary>
        SV_DISKSPACETHRESHOLD_PARMNUM = 550,
        /// <summary><var>sv*_maxlinkdelay</var></summary>
        SV_MAXLINKDELAY_PARMNUM = 552,
        /// <summary><var>sv*_minlinkthroughput</var></summary>
        SV_MINLINKTHROUGHPUT_PARMNUM = 553,
        /// <summary><var>sv*_linkinfovalidtime</var></summary>
        SV_LINKINFOVALIDTIME_PARMNUM = 554,
        /// <summary><var>sv*_scavqosinfoupdatetime</var></summary>
        SV_SCAVQOSINFOUPDATETIME_PARMNUM = 555,
        /// <summary><var>sv*_maxworkitemidletime</var></summary>
        SV_MAXWORKITEMIDLETIME_PARMNUM = 556,
        /// <summary><var>sv*_maxrawworkitems</var></summary>
        SV_MAXRAWWORKITEMS_PARMNUM = 557,
        /// <summary><var>sv*_producttype</var></summary>
        SV_PRODUCTTYPE_PARMNUM = 560,
        /// <summary><var>sv*_serversize</var></summary>
        SV_SERVERSIZE_PARMNUM = 561,
        /// <summary><var>sv*_connectionlessautodisc</var></summary>
        SV_CONNECTIONLESSAUTODISC_PARMNUM = 562,
        /// <summary><var>sv*_sharingviolationretries</var></summary>
        SV_SHARINGVIOLATIONRETRIES_PARMNUM = 563,
        /// <summary><var>sv*_sharingviolationdelay</var></summary>
        SV_SHARINGVIOLATIONDELAY_PARMNUM = 564,
        /// <summary><var>sv*_maxglobalopensearch</var></summary>
        SV_MAXGLOBALOPENSEARCH_PARMNUM = 565,
        /// <summary><var>sv*_removeduplicatesearches</var></summary>
        SV_REMOVEDUPLICATESEARCHES_PARMNUM = 566,
        /// <summary><var>sv*_lockviolationretries</var></summary>
        SV_LOCKVIOLATIONRETRIES_PARMNUM = 567,
        /// <summary><var>sv*_lockviolationoffset</var></summary>
        SV_LOCKVIOLATIONOFFSET_PARMNUM = 568,
        /// <summary><var>sv*_lockviolationdelay</var></summary>
        SV_LOCKVIOLATIONDELAY_PARMNUM = 569,
        /// <summary><var>sv*_mdlreadswitchover</var></summary>
        SV_MDLREADSWITCHOVER_PARMNUM = 570,
        /// <summary><var>sv*_cachedopenlimit</var></summary>
        SV_CACHEDOPENLIMIT_PARMNUM = 571,
        /// <summary><var>sv*_criticalthreads</var></summary>
        SV_CRITICALTHREADS_PARMNUM = 572,
        /// <summary><var>sv*_restrictnullsessaccess</var></summary>
        SV_RESTRICTNULLSESSACCESS_PARMNUM = 573,
        /// <summary><var>sv*_enablewfw311directipx</var></summary>
        SV_ENABLEWFW311DIRECTIPX_PARMNUM = 574,
        /// <summary><var>sv*_otherqueueaffinity</var></summary>
        SV_OTHERQUEUEAFFINITY_PARMNUM = 575,
        /// <summary><var>sv*_queuesamplesecs</var></summary>
        SV_QUEUESAMPLESECS_PARMNUM = 576,
        /// <summary><var>sv*_balancecount</var></summary>
        SV_BALANCECOUNT_PARMNUM = 577,
        /// <summary><var>sv*_preferredaffinity</var></summary>
        SV_PREFERREDAFFINITY_PARMNUM = 578,
        /// <summary><var>sv*_maxfreerfcbs</var></summary>
        SV_MAXFREERFCBS_PARMNUM = 579,
        /// <summary><var>sv*_maxfreemfcbs</var></summary>
        SV_MAXFREEMFCBS_PARMNUM = 580,
        /// <summary><var>sv*_maxfreelfcbs</var></summary>
        SV_MAXFREELFCBS_PARMNUM = 581,
        /// <summary><var>sv*_maxfreepagedpoolchunks</var></summary>
        SV_MAXFREEPAGEDPOOLCHUNKS_PARMNUM = 582,
        /// <summary><var>sv*_minpagedpoolchunksize</var></summary>
        SV_MINPAGEDPOOLCHUNKSIZE_PARMNUM = 583,
        /// <summary><var>sv*_maxpagedpoolchunksize</var></summary>
        SV_MAXPAGEDPOOLCHUNKSIZE_PARMNUM = 584,
        /// <summary><var>sv*_sendsfrompreferredprocessor</var></summary>
        SV_SENDSFROMPREFERREDPROCESSOR_PARMNUM = 585,
        /// <summary><var>sv*_maxthreadsperqueue</var></summary>
        SV_MAXTHREADSPERQUEUE_PARMNUM = 586,
        /// <summary><var>sv*_cacheddirectorylimit</var></summary>
        SV_CACHEDDIRECTORYLIMIT_PARMNUM = 587,
        /// <summary><var>sv*_maxcopylength</var></summary>
        SV_MAXCOPYLENGTH_PARMNUM = 588,
        /// <summary><var>sv*_enablecompression</var></summary>
        SV_ENABLECOMPRESSION_PARMNUM = 590,
        /// <summary><var>sv*_autosharewks</var></summary>
        SV_AUTOSHAREWKS_PARMNUM = 591,
        /// <summary><var>sv*_autoshareserver</var></summary>
        SV_AUTOSHARESERVER_PARMNUM = 592,
        /// <summary><var>sv*_enablesecuritysignature</var></summary>
        SV_ENABLESECURITYSIGNATURE_PARMNUM = 593,
        /// <summary><var>sv*_requiresecuritysignature</var></summary>
        SV_REQUIRESECURITYSIGNATURE_PARMNUM = 594,
        /// <summary><var>sv*_minclientbuffersize</var></summary>
        SV_MINCLIENTBUFFERSIZE_PARMNUM = 595,
        /// <summary><var>sv*_connectionnosessionstimeout</var></summary>
        SV_CONNECTIONNOSESSIONSTIMEOUT_PARMNUM = 596,
        /// <summary><var>sv*_idlethreadtimeout</var></summary>
        SV_IDLETHREADTIMEOUT_PARMNUM = 597,
        /// <summary><var>sv*_enablew9xsecuritysignature</var></summary>
        SV_ENABLEW9XSECURITYSIGNATURE_PARMNUM = 598,
        /// <summary><var>sv*_enforcekerberosreauthentication</var></summary>
        SV_ENFORCEKERBEROSREAUTHENTICATION_PARMNUM = 599,
        /// <summary><var>sv*_disabledos</var></summary>
        SV_DISABLEDOS_PARMNUM = 600,
        /// <summary><var>sv*_lowdiskspaceminimum</var></summary>
        SV_LOWDISKSPACEMINIMUM_PARMNUM = 601,
        /// <summary><var>sv*_disablestrictnamechecking</var></summary>
        SV_DISABLESTRICTNAMECHECKING_PARMNUM = 602,
        /// <summary><var>sv*_enableauthenticateusersharing</var></summary>
        SV_ENABLEAUTHENTICATEUSERSHARING_PARMNUM = 603,
    }
}
