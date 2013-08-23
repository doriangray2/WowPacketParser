using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_3_0_16981
{
    public static class Opcodes_5_3_0
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_AUTH_SESSION, 0x09F1},
            {Opcode.CMSG_CAST_SPELL, 0x01CE},
            {Opcode.CMSG_CHAR_CREATE, 0x0404},
            {Opcode.CMSG_CHAR_DELETE, 0x010C},
            {Opcode.CMSG_CHAR_ENUM, 0x0B1D}, //
            {Opcode.CMSG_CREATURE_QUERY, 0x050F},
            {Opcode.CMSG_DB_QUERY_BULK, 0x0149},
            {Opcode.CMSG_DISMISS_CONTROLLED_VEHICLE, 0x0A56},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x058F},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x1341},
            {Opcode.CMSG_LEARN_TALENT, 0x2002},
            {Opcode.CMSG_LOAD_SCREEN, 0x0341},
            {Opcode.CMSG_LOG_DISCONNECT, 0x09A2},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x1150},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x016A},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x143A},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1333},
            {Opcode.CMSG_MOVE_FALL_RESET, 0x0AC3},
            {Opcode.CMSG_MOVE_SET_FLY, 0x0ADF},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x009E},
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x2001},
            {Opcode.CMSG_PING, 0x08E3},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0A19},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x091D},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x0755},
            {Opcode.CMSG_REALM_SPLIT, 0x0B48},
            {Opcode.CMSG_REDIRECTION_AUTH_PROOF, 0x1AA1},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x0400},
            {Opcode.CMSG_SET_SELECTION, 0x1759},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x005B},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x0405},
            //{Opcode.CMSG_UNKNOWN_1243, 0x04DB},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x054B},
            {Opcode.CMSG_ZONEUPDATE, 0x2000},
            {Opcode.MSG_MOVE_FALL_LAND, 0x0CCF},
            {Opcode.MSG_MOVE_HEARTBEAT, 0x0E0B},
            {Opcode.MSG_MOVE_JUMP, 0x0CCA},
            {Opcode.MSG_MOVE_SET_FACING, 0x0886},
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x081F},
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x0856},
            {Opcode.MSG_MOVE_START_ASCEND, 0x089F},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x08D2},
            {Opcode.MSG_MOVE_START_DESCEND, 0x0893},
            {Opcode.MSG_MOVE_START_FORWARD, 0x0A4B},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x0C02},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x0A12},
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0x0816},
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x0843},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x0A9E},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x0A07},
            {Opcode.MSG_MOVE_START_SWIM, 0x0C13},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x0A47},
            {Opcode.MSG_MOVE_STOP, 0x0813},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x0AC7},
            {Opcode.MSG_MOVE_STOP_STRAFE, 0xA4A},
            {Opcode.MSG_MOVE_STOP_SWIM, 0x0C93},
            {Opcode.MSG_MOVE_STOP_TURN, 0x080A},
            {Opcode.MSG_MOVE_TELEPORT, 0x0C54},
            {Opcode.MSG_MOVE_TOGGLE_COLLISION_CHEAT, 0x0A5f},
            {Opcode.MSG_VERIFY_CONNECTIVITY, 0x18A1},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0CD1},
            {Opcode.SMSG_ADDON_INFO, 0x0C80},
            {Opcode.SMSG_AREA_TRIGGER_MOVEMENT_UPDATE, 0x0A91},
            {Opcode.SMSG_ARENA_TEAM_COMMAND_RESULT, 0x06C1},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x05A5},
            {Opcode.SMSG_ATTACKSTART, 0x11D5},
            {Opcode.SMSG_ATTACKSTOP, 0x0690},
            {Opcode.SMSG_AURA_UPDATE, 0x036E},
            {Opcode.SMSG_AURA_UPDATE_ALL, 0x176C},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0221},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0890},
            {Opcode.SMSG_AVERAGE_ITEM_LEVEL_INFORM, 0x04C5},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTRY_INVITE, 0x14D8},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTERED, 0x06D9},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECTED, 0x0091},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECT_PENDING, 0x0095},
            {Opcode.SMSG_BATTLEFIELD_MGR_EXIT_REQUEST, 0x05C5},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_INVITE, 0x0485},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_REQUEST_RESPONSE, 0x0D88},
            {Opcode.SMSG_BATTLEFIELD_MGR_STATE_CHANGE, 0x09C1},
            {Opcode.SMSG_BATTLEFIELD_PORT_DENIED, 0x0F90},
            {Opcode.SMSG_BATTLEFIELD_RATED_INFO, 0x079D},
            {Opcode.SMSG_BATTLEFIELD_STATUS_ACTIVE, 0x0CD8},
            {Opcode.SMSG_BATTLEFIELD_STATUS_FAILED, 0x0798},
            {Opcode.SMSG_BATTLEFIELD_STATUS_NEEDCONFIRMATION, 0x09D5},
            {Opcode.SMSG_BATTLEFIELD_STATUS_QUEUED, 0x11D1},
            {Opcode.SMSG_BATTLEFIELD_STATUS_WAITFORGROUPS, 0x0BDC},
            {Opcode.SMSG_BATTLEGROUND_INFO_THROTTLED, 0x0D9D},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_POSITIONS, 0x03CC},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_JOINED, 0x1281},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_LEFT, 0x1581},
            //{Opcode.SMSG_BATTLEPET_PET_UPDATES, 0x14CC},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x04CC},
            {Opcode.SMSG_CHAR_CREATE, 0x1495},
            {Opcode.SMSG_CHAR_ENUM, 0x0FDD},
            {Opcode.SMSG_CLEAR_BOSS_EMOTES, 0x1395},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x1489},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x13C9},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x06D8},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x1109},
            {Opcode.SMSG_CUSTOM_LOAD_SCREEN, 0x03DC},
            {Opcode.SMSG_DB_REPLY, 0x00DC},
            {Opcode.SMSG_DESTROY_OBJECT, 0x04D1},
            {Opcode.SMSG_DIFFERENT_INSTANCE_FROM_PARTY, 0x0DD5},
            {Opcode.SMSG_DISENCHANT_CREDIT, 0x12C9},
            {Opcode.SMSG_DISMOUNTRESULT, 0x0CC5},
            {Opcode.SMSG_DISPLAY_GAME_ERROR, 0x07D5},
            {Opcode.SMSG_DUMP_RIDE_TICKETS_RESPONSE, 0x10D5},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x02CD},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x15D1},
            {Opcode.SMSG_GAMEOBJECT_CUSTOM_ANIM, 0x028D},
            {Opcode.SMSG_GAMEOBJECT_DESPAWN_ANIM, 0x0981},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x0290},
            {Opcode.SMSG_GAME_EVENT_DEBUG_LOG, 0x0190},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x13AD},
            {Opcode.SMSG_MESSAGECHAT, 0x0699},
            {Opcode.SMSG_GROUPACTION_THROTTLED, 0x1394},
            {Opcode.SMSG_GROUP_INVITE, 0x11DD},
            {Opcode.SMSG_GUILD_REPUTATION_WEEKLY_CAP, 0x1A83},
            {Opcode.SMSG_GUILD_ROSTER, 0x0C0A},
            {Opcode.SMSG_HOTFIX_INFO, 0x1584},
            {Opcode.SMSG_HOTFIX_NOTIFY, 0x0EDC},
            {Opcode.SMSG_INITIAL_SPELLS, 0x173F},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0FDC},
            {Opcode.SMSG_INSPECT_HONOR_STATS, 0x109C},
            {Opcode.SMSG_INSPECT_RATED_BG_STATS, 0x1498},
            {Opcode.SMSG_ITEM_ADD_PASSIVE, 0x1384},
            {Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x0F81},
            {Opcode.SMSG_ITEM_REFUND_RESULT, 0x06C5},
            {Opcode.SMSG_ITEM_REMOVE_PASSIVE, 0x1298},
            {Opcode.SMSG_ITEM_SEND_PASSIVE, 0x0DDD},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x09CC},
            {Opcode.SMSG_MAP_OBJ_EVENTS, 0x0A84},
            {Opcode.SMSG_MESSAGE_BOX, 0x14D9},
            {Opcode.SMSG_MISSILE_CANCEL, 0x03CD},
            {Opcode.SMSG_MONEY_NOTIFY, 0x0DCC},
            {Opcode.SMSG_MONSTER_MOVE, 0x114C},
            {Opcode.SMSG_MOTD, 0x12DC},
            {Opcode.SMSG_MOUNTRESULT, 0x15D0},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x0F48},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x034D},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x0E54},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x0758},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x0904},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x051D},
            {Opcode.SMSG_NEW_WORLD, 0x04D9},
            {Opcode.SMSG_NEW_WORLD_ABORT, 0x0399},
            {Opcode.SMSG_PETITION_ALREADY_SIGNED, 0x10CD},
            {Opcode.SMSG_PET_ADDED, 0x0DD4},
            {Opcode.SMSG_PET_MODE, 0x0085},
            {Opcode.SMSG_PET_SLOT_UPDATED, 0x03C0},
            {Opcode.SMSG_PLAYERBOUND, 0x12DD},
            {Opcode.SMSG_PLAY_SPELL_VISUAL, 0x01C1},
            {Opcode.SMSG_PONG, 0x1121},
            {Opcode.SMSG_PRINT_NOTIFICATION, 0x15CC},
            {Opcode.SMSG_PVP_LOG_DATA, 0x0795},
            {Opcode.SMSG_PVP_OPTIONS_ENABLED, 0x0381},
            {Opcode.SMSG_RAID_MARKERS_CHANGED, 0x0595},
            {Opcode.SMSG_RATED_BG_RATING, 0x05C8},
            {Opcode.SMSG_RATED_BG_STATS, 0x0394},
            {Opcode.SMSG_REALM_SPLIT, 0x0F89},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0328},
            {Opcode.SMSG_REFORGE_RESULT, 0x03D5},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x1389},
            {Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x0DD1},
            {Opcode.SMSG_RESURRECT_REQUEST, 0x0FD0},
            {Opcode.SMSG_REQUEST_PVP_REWARDS_RESPONSE, 0x0389},
            {Opcode.SMSG_ROLE_POLL_BEGIN, 0x0CDC},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x0BD4},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x0A80},
            {Opcode.SMSG_SHOW_RATINGS, 0x0A85},
            {Opcode.SMSG_SPELL_GO, 0x0765},
            {Opcode.SMSG_SPELL_START, 0x1675},
            {Opcode.SMSG_STABLE_RESULT, 0x118D},
            {Opcode.SMSG_START_TIMER, 0x0988},
            {Opcode.SMSG_STREAMING_MOVIE, 0x989},
            {Opcode.SMSG_SUPPRESS_NPC_GREETINGS, 0x0F85},
            {Opcode.SMSG_SUSPEND_TOKEN_RESPONSE, 0x03DD},
            {Opcode.SMSG_TEXT_EMOTE, 0x1185},
            {Opcode.SMSG_TIME_ADJUSTMENT, 0x159C},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x0AD4},
            {Opcode.SMSG_TRADE_STATUS, 0x0DC0},
            {Opcode.SMSG_TRANSFER_PENDING, 0x13CD},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x15BE},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0D7E},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x03ED},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x13BF},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x07F4},
            {Opcode.SMSG_UPDATE_OBJECT, 0x0C65},
            {Opcode.SMSG_UPDATE_SERVER_PLAYER_POSITION, 0x0E84},
            {Opcode.SMSG_WAIT_QUEUE_FINISH, 0x06C8},
            {Opcode.SMSG_WAIT_QUEUE_UPDATE, 0x05D1},
            {Opcode.SMSG_WARDEN_DATA, 0x12D9},
            {Opcode.SMSG_WARGAME_REQUEST_SENT, 0x0E85},
            {Opcode.SMSG_WEEKLY_LAST_RESET, 0x01D4},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x1091},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x0F9C},
            {Opcode.SMSG_VOID_STORAGE_FAILED, 0x078D},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x06C9},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x05C9},
            {Opcode.SMSG_XP_GAIN_ABORTED, 0x1188},
        };
    }
}
