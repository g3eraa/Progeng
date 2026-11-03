#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
TEST_PROJECT="$SCRIPT_DIR/SdiVariant10.Tests/SdiVariant10.Tests.csproj"
RESULTS_DIR="$SCRIPT_DIR/TestResults"

find_dotnet() {
    if command -v dotnet >/dev/null 2>&1; then
        command -v dotnet
        return
    fi

    local candidate
    for candidate in "${DOTNET_ROOT:-/usr/local/share/dotnet}/dotnet" \
                     /private/tmp/progeng-dotnet/dotnet; do
        if [[ -x "$candidate" ]]; then
            printf '%s\n' "$candidate"
            return
        fi
    done
    return 1
}

if ! DOTNET_BIN="$(find_dotnet)"; then
    printf '%s\n' 'Не найден .NET SDK. Установите SDK 8 или новее и среду выполнения .NET 8.' >&2
    exit 1
fi

export DOTNET_CLI_TELEMETRY_OPTOUT=1

printf '%s\n' 'Запуск тестов SDI — вариант 10'
"$DOTNET_BIN" test "$TEST_PROJECT" \
    --configuration Release \
    --logger "console;verbosity=normal" \
    --logger "trx;LogFileName=tests.trx" \
    --results-directory "$RESULTS_DIR" \
    --nologo -m:1 -nr:false -p:UseSharedCompilation=false "$@"

printf '\nОтчёт сохранён: %s/tests.trx\n' "$RESULTS_DIR"
