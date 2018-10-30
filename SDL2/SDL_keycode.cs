using System;
using System.Runtime.InteropServices;

using SDL2;
using static SDL2.SDL_audio;
using static SDL2.SDL_blendmode;
using static SDL2.SDL_clipboard;
using static SDL2.SDL_cpuinfo;
using static SDL2.SDL_error;
using static SDL2.SDL_events;
using static SDL2.SDL_gamecontroller;
using static SDL2.SDL_gesture;
using static SDL2.SDL_haptic;
using static SDL2.SDL_hints;

using static SDL2.SDL_joystick;
using static SDL2.SDL_keyboard;
using static SDL2.SDL_messagebox;
using static SDL2.SDL_mouse;
using static SDL2.SDL_pixels;
using static SDL2.SDL_power;
using static SDL2.SDL_rect;
using static SDL2.SDL_render;
using static SDL2.SDL_scancode;
using static SDL2.SDL_surface;

using static SDL2.SDL_touch;
using static SDL2.SDL_version;
using static SDL2.SDL_video;
using NativeLibraryLoader;

namespace SDL2
{
    public static class SDL_keycode
    {
        public const int SDLK_SCANCODE_MASK = 1 << 30;
        public const int KMOD_CTRL = (int)SDL_Keymod.KMOD_LCTRL | (int)SDL_Keymod.KMOD_RCTRL;
        public const int KMOD_SHIFT = (int)SDL_Keymod.KMOD_LSHIFT | (int)SDL_Keymod.KMOD_RSHIFT;
        public const int KMOD_ALT = (int)SDL_Keymod.KMOD_LALT | (int)SDL_Keymod.KMOD_RALT;
        public const int KMOD_GUI = (int)SDL_Keymod.KMOD_LGUI | (int)SDL_Keymod.KMOD_RGUI;

        [Flags]
        public enum SDL_Keymod
        {

            KMOD_NONE = 0x0000,
            KMOD_LSHIFT = 0x0001,
            KMOD_RSHIFT = 0x0002,
            KMOD_LCTRL = 0x0040,
            KMOD_RCTRL = 0x0080,
            KMOD_LALT = 0x0100,
            KMOD_RALT = 0x0200,
            KMOD_LGUI = 0x0400,
            KMOD_RGUI = 0x0800,
            KMOD_NUM = 0x1000,
            KMOD_CAPS = 0x2000,
            KMOD_MODE = 0x4000,
            KMOD_RESERVED = 0x8000

        }

        public static int SDL_scancode_to_keycode(int scancode)
        {
            return scancode | SDLK_SCANCODE_MASK;
        }

        public enum SDL_Keycode
        {
            SDLK_UNKNOWN = 0,
            SDLK_BACKSPACE = 8,
            SDLK_TAB = 9,
            SDLK_RETURN = 13,
            SDLK_ESCAPE = 27,
            SDLK_SPACE = 32,
            SDLK_EXCLAIM = 33,
            SDLK_QUOTEDBL = 34,
            SDLK_HASH = 35,
            SDLK_DOLLAR = 36,
            SDLK_PERCENT = 37,
            SDLK_AMPERSAND = 38,
            SDLK_QUOTE = 39,
            SDLK_LEFTPAREN = 40,
            SDLK_RIGHTPAREN = 41,
            SDLK_ASTERISK = 42,
            SDLK_PLUS = 43,
            SDLK_COMMA = 44,
            SDLK_MINUS = 45,
            SDLK_PERIOD = 46,
            SDLK_SLASH = 47,
            SDLK_0 = 48,
            SDLK_1 = 49,
            SDLK_2 = 50,
            SDLK_3 = 51,
            SDLK_4 = 52,
            SDLK_5 = 53,
            SDLK_6 = 54,
            SDLK_7 = 55,
            SDLK_8 = 56,
            SDLK_9 = 57,
            SDLK_COLON = 58,
            SDLK_SEMICOLON = 59,
            SDLK_LESS = 60,
            SDLK_EQUALS = 61,
            SDLK_GREATER = 62,
            SDLK_QUESTION = 63,
            SDLK_AT = 64,
            SDLK_LEFTBRACKET = 91,
            SDLK_BACKSLASH = 92,
            SDLK_RIGHTBRACKET = 93,
            SDLK_CARET = 94,
            SDLK_UNDERSCORE = 95,
            SDLK_BACKQUOTE = 96,
            SDLK_a = 97,
            SDLK_b = 98,
            SDLK_c = 99,
            SDLK_d = 100,
            SDLK_e = 101,
            SDLK_f = 102,
            SDLK_g = 103,
            SDLK_h = 104,
            SDLK_i = 105,
            SDLK_j = 106,
            SDLK_k = 107,
            SDLK_l = 108,
            SDLK_m = 109,
            SDLK_n = 110,
            SDLK_o = 111,
            SDLK_p = 112,
            SDLK_q = 113,
            SDLK_r = 114,
            SDLK_s = 115,
            SDLK_t = 116,
            SDLK_u = 117,
            SDLK_v = 118,
            SDLK_w = 119,
            SDLK_x = 120,
            SDLK_y = 121,
            SDLK_z = 122,
            SDLK_DELETE = 127,
            SDLK_CAPSLOCK = 1073741881,
            SDLK_F1 = 1073741882,
            SDLK_F2 = 1073741883,
            SDLK_F3 = 1073741884,
            SDLK_F4 = 1073741885,
            SDLK_F5 = 1073741886,
            SDLK_F6 = 1073741887,
            SDLK_F7 = 1073741888,
            SDLK_F8 = 1073741889,
            SDLK_F9 = 1073741890,
            SDLK_F10 = 1073741891,
            SDLK_F11 = 1073741892,
            SDLK_F12 = 1073741893,
            SDLK_PRINTSCREEN = 1073741894,
            SDLK_SCROLLLOCK = 1073741895,
            SDLK_PAUSE = 1073741896,
            SDLK_INSERT = 1073741897,
            SDLK_HOME = 1073741898,
            SDLK_PAGEUP = 1073741899,
            SDLK_END = 1073741901,
            SDLK_PAGEDOWN = 1073741902,
            SDLK_RIGHT = 1073741903,
            SDLK_LEFT = 1073741904,
            SDLK_DOWN = 1073741905,
            SDLK_UP = 1073741906,
            SDLK_NUMLOCKCLEAR = 1073741907,
            SDLK_KP_DIVIDE = 1073741908,
            SDLK_KP_MULTIPLY = 1073741909,
            SDLK_KP_MINUS = 1073741910,
            SDLK_KP_PLUS = 1073741911,
            SDLK_KP_ENTER = 1073741912,
            SDLK_KP_1 = 1073741913,
            SDLK_KP_2 = 1073741914,
            SDLK_KP_3 = 1073741915,
            SDLK_KP_4 = 1073741916,
            SDLK_KP_5 = 1073741917,
            SDLK_KP_6 = 1073741918,
            SDLK_KP_7 = 1073741919,
            SDLK_KP_8 = 1073741920,
            SDLK_KP_9 = 1073741921,
            SDLK_KP_0 = 1073741922,
            SDLK_KP_PERIOD = 1073741923,
            SDLK_APPLICATION = 1073741925,
            SDLK_POWER = 1073741926,
            SDLK_KP_EQUALS = 1073741927,
            SDLK_F13 = 1073741928,
            SDLK_F14 = 1073741929,
            SDLK_F15 = 1073741930,
            SDLK_F16 = 1073741931,
            SDLK_F17 = 1073741932,
            SDLK_F18 = 1073741933,
            SDLK_F19 = 1073741934,
            SDLK_F20 = 1073741935,
            SDLK_F21 = 1073741936,
            SDLK_F22 = 1073741937,
            SDLK_F23 = 1073741938,
            SDLK_F24 = 1073741939,
            SDLK_EXECUTE = 1073741940,
            SDLK_HELP = 1073741941,
            SDLK_MENU = 1073741942,
            SDLK_SELECT = 1073741943,
            SDLK_STOP = 1073741944,
            SDLK_AGAIN = 1073741945,
            SDLK_UNDO = 1073741946,
            SDLK_CUT = 1073741947,
            SDLK_COPY = 1073741948,
            SDLK_PASTE = 1073741949,
            SDLK_FIND = 1073741950,
            SDLK_MUTE = 1073741951,
            SDLK_VOLUMEUP = 1073741952,
            SDLK_VOLUMEDOWN = 1073741953,
            SDLK_KP_COMMA = 1073741957,
            SDLK_KP_EQUALSAS400 = 1073741958,
            SDLK_ALTERASE = 1073741977,
            SDLK_SYSREQ = 1073741978,
            SDLK_CANCEL = 1073741979,
            SDLK_CLEAR = 1073741980,
            SDLK_PRIOR = 1073741981,
            SDLK_RETURN2 = 1073741982,
            SDLK_SEPARATOR = 1073741983,
            SDLK_OUT = 1073741984,
            SDLK_OPER = 1073741985,
            SDLK_CLEARAGAIN = 1073741986,
            SDLK_CRSEL = 1073741987,
            SDLK_EXSEL = 1073741988,
            SDLK_KP_00 = 1073742000,
            SDLK_KP_000 = 1073742001,
            SDLK_THOUSANDSSEPARATOR = 1073742002,
            SDLK_DECIMALSEPARATOR = 1073742003,
            SDLK_CURRENCYUNIT = 1073742004,
            SDLK_CURRENCYSUBUNIT = 1073742005,
            SDLK_KP_LEFTPAREN = 1073742006,
            SDLK_KP_RIGHTPAREN = 1073742007,
            SDLK_KP_LEFTBRACE = 1073742008,
            SDLK_KP_RIGHTBRACE = 1073742009,
            SDLK_KP_TAB = 1073742010,
            SDLK_KP_BACKSPACE = 1073742011,
            SDLK_KP_A = 1073742012,
            SDLK_KP_B = 1073742013,
            SDLK_KP_C = 1073742014,
            SDLK_KP_D = 1073742015,
            SDLK_KP_E = 1073742016,
            SDLK_KP_F = 1073742017,
            SDLK_KP_XOR = 1073742018,
            SDLK_KP_POWER = 1073742019,
            SDLK_KP_PERCENT = 1073742020,
            SDLK_KP_LESS = 1073742021,
            SDLK_KP_GREATER = 1073742022,
            SDLK_KP_AMPERSAND = 1073742023,
            SDLK_KP_DBLAMPERSAND = 1073742024,
            SDLK_KP_VERTICALBAR = 1073742025,
            SDLK_KP_DBLVERTICALBAR = 1073742026,
            SDLK_KP_COLON = 1073742027,
            SDLK_KP_HASH = 1073742028,
            SDLK_KP_SPACE = 1073742029,
            SDLK_KP_AT = 1073742030,
            SDLK_KP_EXCLAM = 1073742031,
            SDLK_KP_MEMSTORE = 1073742032,
            SDLK_KP_MEMRECALL = 1073742033,
            SDLK_KP_MEMCLEAR = 1073742034,
            SDLK_KP_MEMADD = 1073742035,
            SDLK_KP_MEMSUBTRACT = 1073742036,
            SDLK_KP_MEMMULTIPLY = 1073742037,
            SDLK_KP_MEMDIVIDE = 1073742038,
            SDLK_KP_PLUSMINUS = 1073742039,
            SDLK_KP_CLEAR = 1073742040,
            SDLK_KP_CLEARENTRY = 1073742041,
            SDLK_KP_BINARY = 1073742042,
            SDLK_KP_OCTAL = 1073742043,
            SDLK_KP_DECIMAL = 1073742044,
            SDLK_KP_HEXADECIMAL = 1073742045,
            SDLK_LCTRL = 1073742048,
            SDLK_LSHIFT = 1073742049,
            SDLK_LALT = 1073742050,
            SDLK_LGUI = 1073742051,
            SDLK_RCTRL = 1073742052,
            SDLK_RSHIFT = 1073742053,
            SDLK_RALT = 1073742054,
            SDLK_RGUI = 1073742055,
            SDLK_MODE = 1073742081,
            SDLK_AUDIONEXT = 1073742082,
            SDLK_AUDIOPREV = 1073742083,
            SDLK_AUDIOSTOP = 1073742084,
            SDLK_AUDIOPLAY = 1073742085,
            SDLK_AUDIOMUTE = 1073742086,
            SDLK_MEDIASELECT = 1073742087,
            SDLK_WWW = 1073742088,
            SDLK_MAIL = 1073742089,
            SDLK_CALCULATOR = 1073742090,
            SDLK_COMPUTER = 1073742091,
            SDLK_AC_SEARCH = 1073742092,
            SDLK_AC_HOME = 1073742093,
            SDLK_AC_BACK = 1073742094,
            SDLK_AC_FORWARD = 1073742095,
            SDLK_AC_STOP = 1073742096,
            SDLK_AC_REFRESH = 1073742097,
            SDLK_AC_BOOKMARKS = 1073742098,
            SDLK_BRIGHTNESSDOWN = 1073742099,
            SDLK_BRIGHTNESSUP = 1073742100,
            SDLK_DISPLAYSWITCH = 1073742101,
            SDLK_KBDILLUMTOGGLE = 1073742102,
            SDLK_KBDILLUMDOWN = 1073742103,
            SDLK_KBDILLUMUP = 1073742104,
            SDLK_EJECT = 1073742105,
            SDLK_SLEEP = 1073742106
        }
    }
}

